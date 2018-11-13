using System;

namespace _001
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (string line; (line = Console.ReadLine()) != "42";)
                Console.WriteLine(line);
        }
    }
}
\