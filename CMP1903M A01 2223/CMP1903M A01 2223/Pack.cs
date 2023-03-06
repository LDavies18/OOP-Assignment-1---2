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
        public static List<string> pack = new List<string>();
        public static List<string> shuffled_pack = new List<string>();
        int pack_length = 52;

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
                    string New_Card_str = New_Card.ToString();
                    pack.Add(New_Card_str); //adds generated card to the pack list 
               
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
                    Random fy_rnd = new Random();
                    int fy_val = fy_rnd.Next(i);
                    string card_pick = pack[i];
                    shuffled_pack.Add(card_pick);
                    
                }
            }
            else if (typeOfShuffle == 2)
            {

            }
            else if (typeOfShuffle == 3)
            {

            }
            else return false;

            return true;
                

        }
        public static Card deal()
        {
            return new Card();
            //Deals one card

        }
        public static List<Card> dealCard(int amount) // int here is input from user in program
        {
            return new List<Card>();
            //Deals the number of cards specified by 'amount'
        }
    }
}
