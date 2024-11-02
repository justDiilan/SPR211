using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BroadcastServer
{
    public class BroadcastServer
    {
        private readonly UdpClient? _udpClient;
        private IPEndPoint? _ipEndPoint;

        public BroadcastServer(int port)
        {
            _udpClient = new UdpClient()
            {
                EnableBroadcast = true
            };
            _ipEndPoint = new IPEndPoint(IPAddress.Broadcast, port);
        }

        //public void Start()
        //{
        //    Console.WriteLine("Broadcast server started...");

        //    while (true)
        //    {
        //        byte[] receivedBytes = _udpClient!.Receive(ref _ipEndPoint!);
        //        string receivedMessage = Encoding.ASCII.GetString(receivedBytes);
        //        Console.WriteLine($"Received broadcast message: {receivedMessage}");
        //    }
        //}

        public void Send(string message)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            _udpClient!.Send(messageBytes, messageBytes.Length, _ipEndPoint);
            Console.WriteLine($"Broadcast message sent: {message}");
        }
    }
}
