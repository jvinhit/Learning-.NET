using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randoms
{
    public class Craps
    {
        static Random rdNumbers = new Random();

        public enum Status
        {
            Continue,
            Won,
            Lost
        };

        public enum DiceName
        {
            Snake_eyes = 1,
            trey = 3,
            seven = 7,
            yo_leven = 11,
            box_cars = 12
        };

        public static int RollDice()
        {
            int die1 = rdNumbers.Next(1, 7);
            int die2 = rdNumbers.Next(1, 7);
            int sum = die1 + die2;

            Console.WriteLine("Player rolled {0} + {1} = {2}", die1, die2, sum);
            return sum;
        }

    }
    class Program
    {

        static void Main(string[] args)
        {
            Random randomNumbers = new Random();
            int face;

            // loop 20 times
            for (int counter = 1; counter <= 20; counter++)
            {

                face = randomNumbers.Next(1, 7);

                Console.Write("{0}  ", face);


                if (counter % 5 == 0)
                    Console.WriteLine();
            }

            // 
            Craps craps = new Craps();
            Craps.Status gameStatus = Craps.Status.Continue;
            int mypoint = 0;
            int sumOfDice = Craps.RollDice();

            switch ((Craps.DiceName)sumOfDice)
            {
                case Craps.DiceName.seven: // win with 7 on first roll 
                case Craps.DiceName.yo_leven:
                    gameStatus = Craps.Status.Won;
                    break;
                case Craps.DiceName.Snake_eyes:
                case Craps.DiceName.trey:
                case Craps.DiceName.box_cars:
                    gameStatus = Craps.Status.Lost;
                    break;
                default:
                    gameStatus = Craps.Status.Continue;
                    mypoint = sumOfDice;
                    Console.WriteLine("points is {0}", mypoint);
                    break;

            }
            while (gameStatus == Craps.Status.Continue)
            {
                sumOfDice = Craps.RollDice();
                if (sumOfDice == mypoint)
                {
                    gameStatus =Craps.Status.Won;
                }
                else
                {
                    if (sumOfDice == (int)Craps.DiceName.seven)
                        gameStatus = Craps.Status.Lost;
                }
                if (gameStatus == Craps.Status.Won)
                {
                    Console.WriteLine("Player wins");
                }
                else 
                    Console.WriteLine("Player Lost");
            }
        }
    }
}
