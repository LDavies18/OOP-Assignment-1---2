using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Testing
    {
        private Pack new_pack;

        public void test_code()
        {
            new_pack = new Pack();
            Console.WriteLine("Demo for Cards");
            new_pack.format_cards_very_aesthetically();

            Console.WriteLine("\n Please enter a shuffle to test: (1 Fisher Yates|2 Riffle|3 None)");
            int test_choice = Int32.Parse(Console.ReadLine());

            if (test_choice > 4)
            {
                Console.WriteLine("Error");
            }
            else;
            {
                Console.WriteLine("\n Demo for Shuffle");
                Pack.shuffleCardPack(test_choice);
                new_pack.format_cards_very_aesthetically();
            }


        } 
       



    }

}
