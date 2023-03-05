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

        private int card_num;
        private int card_suit;
        private string gen_card;
        public string str_suit;
        public string str_num;
        
        //hides card value from being access from outside class
        
        //card value generator 
        public int Num 
        { 
            get { return card_num; }
            set
            {
                Random num_rnd = new Random();
                card_num = (num_rnd.Next(13));
            }
        }

        //card suit generator 
        public int Suit 
        {
            get { return card_suit; }
            set
            {
                Random suit_rnd = new Random();
                card_suit = (suit_rnd.Next(4));
            }
        }

        public string Gen_Card
        {
            get { return gen_card; }
            set
            {
                str_suit = Suit.ToString();
                str_num = Num.ToString();
                gen_card = "Suit" + str_suit + "Value" + str_num;
            }
        }
    }
}
