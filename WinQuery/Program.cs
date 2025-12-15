
using System.Globalization;
using System.Security.Principal;

namespace WinQuery

{
    internal class Program
    {
        static void Main(string[] args)
        {
            
              Console.WriteLine("Welcome to WinQuery!");

            Thread.Sleep(1000);

            Console.WriteLine("Windows Version:");
            Console.WriteLine(Environment.OSVersion.Version);
            //Lists Your Windows installation Version
            Console.WriteLine("Machine name:");
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine("User Name:");
            Console.WriteLine(Environment.UserName);
            Console.WriteLine("Cpu Usage");
            Console.WriteLine(Environment.CpuUsage.TotalTime);
            

        }
    }
}