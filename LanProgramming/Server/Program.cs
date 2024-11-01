using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
{
    private static Dictionary<string, TcpClient> _clients = new Dictionary<string, TcpClient>();
    private static TcpListener _listener;

    static async Task Main(string[] args)
    {
        _listener = new TcpListener(IPAddress.Any, 13000);
        _listener.Start();
        Console.WriteLine("Server started. Waiting for connection...");

        while (true)
        {
            TcpClient client = await _listener.AcceptTcpClientAsync();
            NetworkStream stream = client.GetStream();

            string clientName = await GetUniqueClientName(stream);

            if (!string.IsNullOrEmpty(clientName))
            {
                _clients.Add(clientName, client);

                IPEndPoint clientEndPoint = client.Client.RemoteEndPoint as IPEndPoint;
                Console.WriteLine($"Client connected. IP: {clientEndPoint.Address.ToString()}, Name: {clientName}");

                // Отправляем новому клиенту список всех подключённых клиентов
                await SendClientList(clientName);

                // Уведомляем всех клиентов о новом подключении
                await BroadcastMessage($"[SERVER]: {clientName} has joined the chat.", client);

                Thread clientThread = new Thread(async () => await HandleClient(clientName, client));
                clientThread.Start();
            }
        }
    }

    private async static Task<string> GetUniqueClientName(NetworkStream stream)
    {
        string clientName = null;
        bool nameAccepted = false;

        while (!nameAccepted)
        {
            // Запрашиваем имя у клиента
            byte[] requestNameMessage = Encoding.UTF8.GetBytes("Enter your name: ");
            await stream.WriteAsync(requestNameMessage, 0, requestNameMessage.Length);

            byte[] buffer = new byte[256];
            int bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length);
            clientName = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();

            if (!_clients.ContainsKey(clientName))
            {
                nameAccepted = true;
            }
            else
            {
                // Если имя занято, уведомляем клиента
                byte[] nameTakenMessage = Encoding.UTF8.GetBytes("[SERVER]: This name is already taken. Please choose another one.\n");
                await stream.WriteAsync(nameTakenMessage, 0, nameTakenMessage.Length);
            }
        }

        return clientName;
    }

    private async static Task HandleClient(string clientName, TcpClient client)
    {
        NetworkStream stream = client.GetStream();
        byte[] buffer = new byte[256];
        int bytesRead;

        try
        {
            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) != 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead).Trim();
                Console.WriteLine("Message received: " + message);

                if (message.StartsWith("/pm"))
                {
                    string[] parts = message.Split(' ', 3);
                    if (parts.Length == 3)
                    {
                        string targetClientName = parts[1];
                        string privateMessage = $"(Private) {clientName}: {parts[2]}";
                        await SendPrivateMessage(targetClientName, privateMessage);
                    }
                }
                else
                {
                    await BroadcastMessage($"{clientName}: {message}", client);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            _clients.Remove(clientName);
            Console.WriteLine($"Client {clientName} disconnected.");
            client.Close();
            await BroadcastMessage($"[SERVER]: {clientName} has left the chat.", null);
        }
    }

    private static async Task SendPrivateMessage(string clientName, string message)
    {
        if (_clients.TryGetValue(clientName, out TcpClient targetClient))
        {
            NetworkStream stream = targetClient.GetStream();
            byte[] buffer = Encoding.UTF8.GetBytes(message);
            await stream.WriteAsync(buffer, 0, buffer.Length);
        }
        else
        {
            Console.WriteLine($"Client {clientName} not found.");
        }
    }

    private static async Task BroadcastMessage(string message, TcpClient excludeClient)
    {
        byte[] buffer = Encoding.UTF8.GetBytes(message);

        foreach (var client in _clients.Values)
        {
            if (client != excludeClient)
            {
                try
                {
                    NetworkStream stream = client.GetStream();
                    await stream.WriteAsync(buffer, 0, buffer.Length);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error broadcasting message: " + ex.Message);
                }
            }
        }
    }

    private static async Task SendClientList(string newClientName)
    {
        if (_clients.TryGetValue(newClientName, out TcpClient newClient))
        {
            NetworkStream stream = newClient.GetStream();
            string clientList = "[SERVER]: Connected clients: " + string.Join(", ", _clients.Keys);
            byte[] buffer = Encoding.UTF8.GetBytes(clientList);
            await stream.WriteAsync(buffer, 0, buffer.Length);
        }
    }
}
