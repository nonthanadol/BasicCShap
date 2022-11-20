using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;



namespace TCPIPAppBasic
{
    class ServerApp 
    {
        static void Main(string[] args) 
        {
            Socket sck = new Socket(AddressFamily.InterNetwork,SocketType.Stream,ProtocolType.Tcp); // Create object -> IPv4,TCP

            sck.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"),1990));// open port , bind socket with IP
            Console.WriteLine("Wait for connect");
            sck.Listen(10); //This socket support connection 10 machine 

            Socket acc = sck.Accept(); // connected success
            Console.WriteLine("Connect complete");

            //.....Send data to client
            string message = "Hello";
            byte[] buffer = Encoding.ASCII.GetBytes(message); // Encoding data ASCII to Bytes
            
            acc.Send(buffer,0,buffer.Length,0); // Send data to client MC
            Console.WriteLine("Send data complete");

            //.....Recive from client
            buffer = new byte[1024]; // reserve array 
            int rec = acc.Receive(buffer, 0, buffer.Length, 0); // Recive element data 
            
            Array.Resize(ref buffer, rec); // Change diamention array "buffer" to same size "rec" 
            Console.WriteLine("Recived encoding buffer : {0}", Encoding.Default.GetString(buffer));
            Console.WriteLine("Recived  buffer : {0}", buffer);
            Console.WriteLine("Recived  rec : {0}",rec);
           
            sck.Close(); // Close Port
            acc.Close();
            Console.Read();
        
        }

    }

}