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
        int pack_length = 2;
        private static int dealt_card_count = 0;

        public Pack()
        {
            //Initialise the card pack here
            //values of card pack
            //geenerates all values of card for one suit at a time

            for (int card_suit = 1; card_suit < 5; card_suit++)  //Loops for all 4 suits
            {
                for (int card_value = 1;card_value < 14; card_value++)  //Loops for all 13 Values
                {
                    Card New_Card = new Card();  //generates card object 
                    New_Card.Suit = card_suit;
                    New_Card.Value = card_value;
                    pack.Add(New_Card); //adds generated card to the pack list 
               
                }
            }
        }

        public static bool shuffleCardPack(int typeOfShuffle) // int here is input from user in program - bool needs false at the end of if/else statements
        {
            //Shuffles the pack based on the type of shuffle from user int input 
            if (typeOfShuffle == 1) //Fisher Yates Shuffle 
            {
                List<Card> shuffled_pack_fy = new List<Card>(); //generates new list called shuffled_pack to store shuffled cards
                Random fy_rnd = new Random();  //generates new random number 
                for (int i = 52; i > 0; i--)
                {
                    int fy_val = fy_rnd.Next(i);   //generates a random int within the limit of i
                    Card card_pick = pack[fy_val];   // makes variable of card selected at random location
                    shuffled_pack_fy.Add(card_pick);  // adds card selected to new shuffled deck
                    pack.Remove(card_pick);  //removes card selected from the original deck

                }
                pack.Clear();  // resets the pack so that it is empty 
                pack.AddRange(shuffled_pack_fy); // transfers shuffled pack to the orginal pack
            }
            else if (typeOfShuffle == 2)// Riffle Shuffle
            {
                List<Card> shuffled_pack_r = new List<Card>(); //creates new lists for shuffled pack, and two half packs to split the original pack in two
                List<Card> half_pack_1 = new List<Card>();
                List<Card> half_pack_2 = new List<Card>();
                for (int j = 0; j < 26; j++)
                {
                    half_pack_1.Add(pack[j]); // splits first half of deck into half 1
                }
                for (int k = 26; k < 52; k++)
                {
                    half_pack_2.Add(pack[k]); //splits second half of deck into half 2
                }
                for (int l = 0; l < 26; l++)
                {
                    shuffled_pack_r.Add(half_pack_1[l]);
                    shuffled_pack_r.Add(half_pack_2[l]); // adds first card  of each half to the shuffled deck         
                }
                pack.Clear(); // resets the pack so that it is empty
                pack.AddRange(shuffled_pack_r); // transfers shuffled pack to the orginal pack

            }
            else if (typeOfShuffle == 3) //no shuffle
            {
                Console.WriteLine("No Shuffle Selected");
                return true;
            }
            else return false;

            return true;
                

        }
        public static Card deal() 
        { 
            //Deals one card
            Card one_card_deal = pack[dealt_card_count]; //reads the selected card from the pack.
            dealt_card_count++;// increaments by one so that the next card can be read if deal is called again.
            return one_card_deal; //returns the card selected

        }
        public static List<Card> dealCard(int amount) // int here is input from user in program
        {
            //Deals the number of cards specified by 'amount'
            List<Card> dealt_pack = new List<Card>(); //generates a new pack for the cards to be dealt from
            if (pack.Count > amount) //amount is entered by user in testing to deal that specific amount of cards
            {
                if (amount > 52)
                    amount = 52;

                for (int m = 0; m < amount; m++)
                {
                    dealt_pack.Add(pack[0]);//adds the original pack to the dealt pack
                    pack.Remove(pack[0]); //removes the remaing cards from the original pack 
                }
            }
            else
            {
                Console.WriteLine("Not enough cards to deal"); //if amount entered is too high this message will be printed
            }

            return dealt_pack;
            
        }
        public void format_cards_very_aesthetically() //Additonal Method to format the cards 
        {
            foreach (Card card in pack) //Takes the value from the object and makes it into a readable string
            {
                Console.Write($"|{card.Suit}~{card.Value}|");
            }

        }
        public void format_cards_very_aesthetically(List<Card> p)  //Additonal Method to format the cards 
        {
            foreach (Card card in p)//Takes the value from the object and makes it into a readable string
            {
                Console.Write($"|{card.Suit}~{card.Value}|");
            }
        }
    }
}
