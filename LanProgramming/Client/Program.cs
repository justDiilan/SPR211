using System.Net;
using System.Net.Sockets;
using System.Text;

class Client
{
    private static TcpClient _client;
    private static NetworkStream _stream;
    private static string _clientName;

    static async Task Main(string[] args)
    {
        try
        {
            _client = new TcpClient();
            await _client.ConnectAsync("26.96.70.219", 13000);

            _stream = _client.GetStream();

            while (string.IsNullOrEmpty(_clientName))
            {
                Console.Write("Enter your name: ");
                string nameInput = Console.ReadLine();
                byte[] nameData = Encoding.UTF8.GetBytes(nameInput);
                await _stream.WriteAsync(nameData, 0, nameData.Length);

                // Ожидание ответа от сервера
                byte[] buffer = new byte[256];
                int bytesRead = await _stream.ReadAsync(buffer, 0, buffer.Length);
                string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                if (!response.Contains("already taken"))
                {
                    _clientName = nameInput;
                }
                else
                {
                    Console.WriteLine(response); // Выводим сообщение о занятости имени
                }
            }

            Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
            receiveThread.Start();
            Console.WriteLine("Connected to server. Enter message: ");

            while (true)
            {
                string message = Console.ReadLine();

                if (message.Equals("/quit", StringComparison.OrdinalIgnoreCase))
                {
                    break;  // Выход из цикла для отключения
                }

                byte[] data = Encoding.UTF8.GetBytes(message);
                await _stream.WriteAsync(data, 0, data.Length);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
            Console.ReadLine();
        }
        finally
        {
            _stream?.Close();  // Закрываем поток
            _client?.Close();  // Закрываем клиента
            Console.WriteLine("Disconnected from server.");

            Console.ReadLine();
        }
    }

    private async static void ReceiveMessage()
    {
        try
        {
            while (_client.Connected)
            {
                byte[] data = new byte[256];
                StringBuilder builder = new StringBuilder();
                int bytesRead = 0;

                do
                {
                    bytesRead = await _stream.ReadAsync(data, 0, data.Length);
                    builder.Append(Encoding.UTF8.GetString(data, 0, bytesRead));
                }
                while (_stream.DataAvailable);

                if (builder.Length > 0)
                {
                    Console.WriteLine(builder.ToString());
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
