using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        //list generation for deck and shuffled decks
        public static List<Card> pack = new List<Card>(); // original
        public static List<Card> shuffled_pack = new List<Card>(); //for shuffled decks
        public static List<Card> half_pack_1= new List<Card>(); // For R Shuffle
        public static List<Card> half_pack_2 = new List<Card>(); // For R Shuffle
        public static List<Card> dealt_pack = new List<Card>(); //for dealt pack
        int pack_length = 2;

        public Pack()
        {
            //Initialise the card pack here
            //values of card pack
            //geenerates all values of card for one suit at a time

            for (int card_suit = 1; card_suit < 5; card_suit ++)  //Loops for all 4 suits
            {
                for (int card_value = 1; card_value < 14; card_value++)  //Loops for all 13 Values
                {
                    Card New_Card = new Card();  //generates card object 
                    pack.Add(New_Card); //adds generated card to the pack list 
               
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle) // int here is input from user in program - bool needs false at the end of if/else statements
        {
            //Shuffles the pack based on the type of shuffle
            if (typeOfShuffle == 1) //Fisher Yates Shuffle 
            {
                for (int i = 51; i > 0; i--)
                {
                    Console.WriteLine("Fisher Yates Shuffle Selected");
                    Random fy_rnd = new Random();
                    int fy_val = fy_rnd.Next(i);   //generates a random int within the limit of i
                    Card card_pick = pack[i];   // makes variable of card selected at random location
                    shuffled_pack.Add(card_pick);  // adds card selected to new shuffled deck
                    pack.Remove(card_pick);  //removes card selected from the original deck

                }
            }
            else if (typeOfShuffle == 2)// Riffle Shuffle
            {
                Console.WriteLine("Riffle Shuffle Selected");
                for (int j = 0; j < 26; j++)
                {
                    half_pack_1.Add(pack[j]); // splits first half of deck into half 1
                }
                for (int k = 0; k < 26; k++)
                {
                    half_pack_2.Add(pack[k]); //splits second half of deck into half 2
                }
                for (int l = 0; l < 26; l++)
                {
                    shuffled_pack.Add(half_pack_1[l]);
                    shuffled_pack.Add(half_pack_2[l]); // adds first card  of each half to the shuffled deck         
                }


            }
            else if (typeOfShuffle == 3)
            {
                Console.WriteLine("No Shuffle Selected");
                shuffled_pack.AddRange(pack); //transfers orginal deck to shuffled deck so it can be used in the deal
            }
            else return false;

            return true;
                

        }
        public static Card deal()
        { 
            //Deals one card
            Card one_card_deal = shuffled_pack[0];
            return one_card_deal;

        }
        public static List<Card> dealCard(int amount) // int here is input from user in program
        {
            //Deals the number of cards specified by 'amount'
            if (amount > 52)
                amount = 52;
               
            for (int m = 0 ; m > amount; m--)
            {
                dealt_pack.Add(shuffled_pack[m]);
            }
            Console.WriteLine(dealt_pack);
            return dealt_pack ;
        }
    }
}
