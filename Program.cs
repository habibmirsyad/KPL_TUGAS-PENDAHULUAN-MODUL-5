using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul5_1302201138
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===NORMAL_TEST===");
            SayaTubeVideo tube = new SayaTubeVideo("Tutorial Design By Contract - [Habib]");
            tube.IncreasePlayCount(5);
            tube.printVideoDetails();

            Console.WriteLine("\n");

            Console.WriteLine("===ERROR_TEST===");
            SayaTubeVideo err = new SayaTubeVideo("1234567890 1234567890 1234567890 1234567890 1234567890 1234567890 1234567890 1234567890 1234567890 1234567890");
            err.IncreasePlayCount(10000001);
            err.printVideoDetails();

        }
    }
}
