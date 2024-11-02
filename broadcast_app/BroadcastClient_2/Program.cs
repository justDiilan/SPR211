using System.Net.Sockets;
using System.Net;
using System.Text;

namespace BroadcastClient_2
{
    internal class Program
    {
        private static int broadcastPort = 8888;

        public static void ReceiveBroadcast()
        {
            using (UdpClient udpClient = new UdpClient())
            {
                udpClient.EnableBroadcast = true;

                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, broadcastPort);

                udpClient.Client.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                udpClient.Client.Bind(endPoint);

                Console.WriteLine("Waiting for messages...");

                while (true)
                {
                    byte[] receivedBytes = udpClient.Receive(ref endPoint);
                    string receivedMessage = Encoding.UTF8.GetString(receivedBytes);
                    Console.WriteLine("Receive message: " + receivedMessage);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Client started. Waiting for broadcast-message...");
            ReceiveBroadcast();
        }
    }
}