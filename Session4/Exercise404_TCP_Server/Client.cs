using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Exercise404_TCP_Server
{
    class Client
    {
        private TcpClient client;
        private NetworkStream ns;
        private byte[] data = new byte[1024];

        public Client(TcpClient cln)
        {
            client = cln;
            ns = client.GetStream();
        }

        public void Start()
        {
            Thread t = new Thread(Run);
            t.Start();
        }

        private void Run()
        {
            SendMsg("Welcome to the DNPI1 test server");
            int recv;

            while (true)
            {
                data = new byte[1024];
                try
                {
                    recv = ns.Read(data, 0, data.Length);
                }
                catch (IOException)
                {
                    break;
                }

                if (recv == 0)
                    break;

                Console.WriteLine($"Message from {client.Client.RemoteEndPoint.ToString()}: {Encoding.ASCII.GetString(data, 0, recv)}");

                SendMsg("Your last message to the server was:");

                ns.Write(data, 0, recv);
            }
            ns.Close();
            client.Close();
        }

        public void SendMsg(string msg)
        {
            byte[] response = new byte[1024];
            response = Encoding.ASCII.GetBytes(msg);
            ns.Write(response, 0, response.Length);
        }
    }
}
