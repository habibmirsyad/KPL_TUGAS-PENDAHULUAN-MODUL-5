﻿using System;
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
            SayaTubeVideo tube = new SayaTubeVideo("Tutorial Design By Contract - [Habib]");
            tube.IncreasePlayCount(2);
            tube.printVideoDetails();
        }
    }
}
