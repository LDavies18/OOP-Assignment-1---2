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
        List<Card> pack;

        public int pack_length;
        public string New_Card_String;

        public Pack()
        {
            //Initialise the card pack here
            //values of card pack

            pack_length = pack.Count;

            for (int card_suit = 1; card_suit < 5; card_suit ++)  //Loops for all 4 suits
            {
                for (int card_value = 1; card_value < 14; card_value++)  //Loops for all 13 Values
                {
                    Card New_Card = new Card();
                    pack.Add(New_Card);
               
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle) // int here is input from user in program
        {
            //Shuffles the pack based on the type of shuffle

        }
        public static Card deal()
        {
            //Deals one card

        }
        public static List<Card> dealCard(int amount) // int here is input from user in program
        {
            //Deals the number of cards specified by 'amount'
        }
    }
}
