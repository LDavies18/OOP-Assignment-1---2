﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter a shuffle to use (Fisher, Riffle, No): ");
            //ypeOfShuffle = Console.ReadLine();
            //object pack class with variable input from user e.g. shuffle type/cards to deal. 

            Testing tests = new Testing();
            tests.runtests();

        }

        
    }
}
