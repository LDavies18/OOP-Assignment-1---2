using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation
        //For one card to then be stored in a pack.

        private int card_value;
        private int card_suit;
        private string gen_card;
        public string str_suit;
        public string str_num;

        //allows card value to be public/unchangeable value
        public int Value
        {
            get { return card_value; }
            set
            {
                card_value = value;
            }
        }

       //allows card suit to be public/unchangeable value
        public int Suit
        {
            get { return card_suit; }
            set
            {
                card_suit = value;
            }
        }

        public string GenCard
        {
            get 
            {
                return "value:" + card_value + "suit:" + card_suit;
            }
        }

    }
}
