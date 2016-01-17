using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Bai52La
{
    public class Card
    {
        private string face;
        private string suit;

        public Card(string f, string s)
        {
            face = f;
            suit = s;
        }

        public override string ToString()
        {
            return face + " of " + suit;
        }

    }

    public class DeckOfCards
    {
        // mang cac con bai

        private Card[] deck;
        // con bai dang cam tren tay
        private int currentCard;
        // mot bo bai chi co 52 con
        private const int NUMBER_OF_CARDS = 52;
        private Random randomNumbers;

        public DeckOfCards()
        {
            string[] faces = { "aT", "hAI", "bA", "bON", "nAM", "sAU", 
         "bAY", "tAM", "cHIN", "mUOI", "bOI", "dAM", "gIA" };
            string[] suits = { "cO", "rO", "cHUON", "bICH" };

            deck = new Card[NUMBER_OF_CARDS];
            currentCard = 0; // set currentCard so deck[ 0 ] is dealt first  
            randomNumbers = new Random(); // create random number generator

            // Tung doi tuong La bai xac dinh mot 

            for (int count = 0; count < deck.Length; count++)
                deck[count] = new Card(faces[count % 13], suits[count / 13]);
        }

        public void Shuffle()
        {
            currentCard = 0;
            for (int first = 0; first < deck.Length; first++)
            {
                int second = randomNumbers.Next(NUMBER_OF_CARDS);

                // swap current Card with randomly selected Card
                Card temp = deck[first];
                deck[first] = deck[second];
                deck[second] = temp;
            } // end for
        } // end method Shuffle

        public Card DealCard()
        {
            // determine whether Cards remain to be dealt
            if (currentCard < deck.Length)
                return deck[currentCard++]; // return current Card in array
            else
                return null; // indicate that all Cards were dealt
        } // end method DealCard
    }
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards myDeckOfCards = new DeckOfCards();
            myDeckOfCards.Shuffle(); // place Cards in random order

            // display all 52 Cards in the order in which they are dealt
            for (int i = 0; i < 52; i++)
            {
                Console.Write("{0,-19}", myDeckOfCards.DealCard());

                if ((i + 1) % 4 == 0)
                    Console.WriteLine();
            } // end for
        }
    }
}
