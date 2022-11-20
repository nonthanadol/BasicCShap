using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;



namespace TCPIPAppClient
{
    class ClientApp
    {
        static void Main(string[] args)
        {
            Socket sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp); // Create object -> IPv4,TCP

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"),1990);
            sck.Connect(endpoint); // Connect server
            Console.Write("Enter massage : ");
            string msg = Console.ReadLine();
            byte[] msgbuffer = Encoding.ASCII.GetBytes(msg);
            
            sck.Send(msgbuffer,0,msgbuffer.Length,0);
            Console.WriteLine("Send data complete");

            byte[] buffer = new byte[1024];
            int rec = sck.Receive(buffer,0,buffer.Length,0);
            Array.Resize(ref buffer, rec);
            Console.WriteLine("Recive encoding buffer : {0} " ,Encoding.Default.GetString(buffer));
            sck.Close();
            Console.Read();

        }

    }

}