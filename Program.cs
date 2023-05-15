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
                    Console.WriteLine($"{serverName}/media > {ip}");
                }
                IPAddress[] addresses2 = Dns.GetHostAddresses(serverName + ".discord.gg");
                foreach (IPAddress ip2 in addresses2)
                {
                    Console.WriteLine($"{serverName}/gg > {ip2}");
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
