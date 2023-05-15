using System;
using System.Net;

namespace Discord_VoIP_Resolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Discord-VoIP-Name > ");
            string serverName = Console.ReadLine();
            try
            {
                IPAddress[] addresses = Dns.GetHostAddresses(serverName + ".discord.media");
                foreach (IPAddress ip in addresses)
                {
                    Console.WriteLine($"{serverName} > {ip}");
                }
            }
            catch
            {
                Console.WriteLine($"Cannot resolve {serverName}");
            }
            Console.ReadKey();
        }
    }
}
