using System.Net;
using System.Net.Sockets;
using System.Text;

class TCPServer
{
    static void Main()
    {
        TcpListener server = new TcpListener(IPAddress.Any, 13000);
        server.Start();
        Console.WriteLine("Waiting connection...");

        TcpClient client = server.AcceptTcpClient();
        Console.WriteLine("Connection establishe.");

        NetworkStream stream = client.GetStream();
        byte[] buffer = Encoding.UTF8.GetBytes("Hello, client!");
        stream.Write(buffer, 0, buffer.Length);

        stream.Close();
        client.Close();
        server.Stop();
    }
}