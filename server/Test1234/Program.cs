
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
            try
            {
                Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                s.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 600));
                s.Listen(9);
                Console.WriteLine("Men dinleyirem");
                Socket client = s.Accept();
                Console.WriteLine("Elaqe yarandi");
                NetworkStream ns = new NetworkStream(client);
                StreamReader sr = new StreamReader(ns);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
               

            }

            catch (SocketException exc)
            {
                Console.WriteLine(exc.Message);
            }
            Console.Read();
        }
    }
}

