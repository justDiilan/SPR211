using System.Net;
using System.Net.Sockets;
using System.Text;

class TCPClient
{
    static void Main()
    {
        TcpClient client = new TcpClient("127.0.0.1", 13000);
        NetworkStream stream = client.GetStream();

        byte[] buffer = new byte[256];
        int bytesRead = stream.Read(buffer, 0, buffer.Length);
        string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

        Console.WriteLine("Message received: " + response);

        stream.Close();
        client.Close();
    }
}