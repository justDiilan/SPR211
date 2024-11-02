using System.Net;
using System.Net.Sockets;
using System.Text;

namespace BroadcastServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            BroadcastServer broadcastServer = new(8888);

            Console.WriteLine("Enter messages to broadcast. Type \'exit\' to quit.");
            string message;

            while ((message = Console.ReadLine()!) != "exit")
            {
                broadcastServer.Send(message);
            }
        }
    }
}
