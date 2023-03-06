using System;
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
            
            //object pack class with variable input from user e.g. shuffle type/cards to deal. 

            Testing tests = new Testing();
            tests.runtests();

           // Console.WriteLine("Please enter a shuffle to use (Fisher (1), Riffle (2), None (3): ");
           // int typeOfShuffle = Convert.ToInt32(Console.ReadLine());

           // Console.WriteLine("Please enter an amount of cards to deal: (Max 52)");
           // int amount = Convert.ToInt32(Console.ReadLine());

           


        }

        
    }
}
