using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    internal class Testing //Implementation of Test class
    {
        private Pack new_pack;

        public void test_code() // new test method 
        {
            new_pack = new Pack();
            Console.WriteLine("Demo for Cards");
            new_pack.format_cards_very_aesthetically(); //formats cards into a string 

            Console.WriteLine("\n Please enter a shuffle to test: (1 Fisher Yates|2 Riffle|3 None)");
            int test_choice = Int32.Parse(Console.ReadLine()); //user input for shuffle select, converted into string

            if (test_choice > 4)
            {
                Console.WriteLine("Error"); //if input is greater than shuffle options error message printed
            }
            else
            {
                Console.WriteLine("\n Demo for Shuffle");
                Pack.shuffleCardPack(test_choice); //shuffles based on selection made 
                new_pack.format_cards_very_aesthetically();
                Card c = Pack.deal(); // ecxecutes deal method 
                Console.WriteLine("Card Dealt:");
                Console.WriteLine(c.ToString()); 

                Console.WriteLine("\n How many cards would you like to deal?: ");
                int deal_choice = Int32.Parse(Console.ReadLine());
                List<Card>dealt = Pack.dealCard(deal_choice); //executes deal card method
                new_pack.format_cards_very_aesthetically(dealt);
            }
            


        } 
       



    }

}
