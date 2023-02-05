using System;
using System.Net.Sockets;

namespace PortScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the start IP address: ");
            string startIp = Console.ReadLine();
            Console.WriteLine("Enter the end IP address: ");
            string endIp = Console.ReadLine();
            Console.WriteLine("Enter the start port: ");
            int startPort = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end port: ");
            int endPort = int.Parse(Console.ReadLine());

            for (int i = startPort; i <= endPort; i++)
            {
                TcpClient tcpScan = new TcpClient();
                try
                {
                    tcpScan.Connect(startIp, i);
                    Console.WriteLine("Port " + i + " is open.");
                    tcpScan.Close();
                }
                catch (Exception)
                {
                    Console.WriteLine("Port " + i + " is closed.");
                }
            }
            Console.WriteLine("Scanning completed.");
            Console.ReadKey();
        }
    }
}
