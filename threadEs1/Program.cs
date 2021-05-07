using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threadEs1
{
    class Program
    {
        public static void StampaNumeri(bool pari)
        {
            Console.WriteLine("ID Thread: " + Thread.CurrentThread.ManagedThreadId);
            if (pari == true)
            {
                StampaNumeriPari();
            }
            else
            {
                StampaNumeriDispari();

            }
        }

        public static void StampaNumeriDispari()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine($"Er numero {i} è DISPARI.");
            }
        }

        public static void StampaNumeriPari()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine($"Er numero {i} è PARI.");
            }
        }

        static void Main(string[] args)
        {
                Thread thread = new Thread(() => StampaNumeri(true));
                thread.Start();

                StampaNumeri(false);

                Console.ReadLine();
        }
    }
}
