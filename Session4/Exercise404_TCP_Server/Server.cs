using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Exercise404_TCP_Server
{
    class Server
    {
        private byte[] adr = { 127, 0, 0, 1 };

        private IPAddress ipAdr;
        private TcpListener newsock;
        private List<Client> clients = new List<Client>();

        public bool Running { get; set; }

        public Server()
        {
            ipAdr = new IPAddress(adr);
            newsock = new TcpListener(ipAdr, 5000);
        }

        public void Start()
        {
            Running = true;
            newsock.Start();
            Thread t = new Thread(Run);
            t.Start();
            Console.WriteLine("Waiting for a client...");
        }

        private void Run()
        {
            while (Running)
            {
                TcpClient tcpclient = newsock.AcceptTcpClient();

                Client newClient = new Client(tcpclient);
                clients.Add(newClient);
                newClient.Start();

                Console.WriteLine($"Client connected :{tcpclient.Client.LocalEndPoint.ToString()}, remote:{tcpclient.Client.RemoteEndPoint.ToString()}");
            }
        }

        public void SendMessage(string msg)
        {
            foreach (var item in clients)
            {
                item.SendMsg(msg);
            }
        }
    }
}
