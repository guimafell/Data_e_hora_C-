using System;

namespace puxando_a_hora
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Today;
            Console.WriteLine(time.ToString());
            Console.WriteLine("");
            Console.WriteLine(time.ToString("D"));
            Console.WriteLine(time.ToString("t"));
            Console.WriteLine(time.ToString("g"));
            Console.ReadKey(true);
        }
    }
}
