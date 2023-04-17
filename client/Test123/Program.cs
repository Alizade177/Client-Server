using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            s.Connect(IPAddress.Parse("127.0.0.1"), 600);
            string data = Console.ReadLine();
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            s.Send(buffer);
            s.Close();
            Console.Read();
        }
    }
}
