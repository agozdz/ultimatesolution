using System;

namespace MyUltimateSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Hello World!");
            for(int i = 0; i < 10; i++) {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(random.Next(1000, 9999));
            }
        }
    }
}
