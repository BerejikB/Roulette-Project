using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Bets
    {
        public void CheckStuff(int X, string color)
        {
            CheckSplit(X);
            CheckCorner(X);
            Check12(X);
            CheckOddEven(X);
            CheckColor(color);
            CheckHalf(X);

        }

        public void CheckSplit(int X)
        {

            int splitLeft;
            int splitRight;

            //Left split dissalow
            //3 6 9 13 15 18 21 24 27 30 33 
            splitLeft = X + 1;
            if (X == 3 || X == 6 || X == 9 || X == 13 || X == 15 || X == 18 || X == 21 || X == 24 || X == 27 || X == 30 || X == 33)
            {

            }
            else
            {
                Console.WriteLine($"Winning split: {splitLeft}");
            }

            //Right split dissalow
            //4 7 10 13 16 19 22 25 28 31 34
            splitRight = X - 1;
            if (X == 4 || X == 7 || X == 10 || X == 13 || X == 16 || X == 19 || X == 22 || X == 25 || X == 28 || X == 31 || X == 34)

            {

            }
            else
            {
                Console.WriteLine($"Winning split: {splitRight} ");
            }

           // Console.WriteLine($"Winning split(s) {splitLeft}{splitRight}");
        }
        public void CheckCorner(int X)
        {



        }
        public void Check12(int X)
        {
            if (X == 1 || X == 2 || X == 3 || X == 4 || X == 5 || X == 6 || X == 7 || X == 8 || X == 9 || X == 10 || X == 11 || X == 12)
            {
                Console.WriteLine("1st 12 bets win");
            }
           else if (X == 13 || X == 14 || X == 15 || X == 16 || X == 17 || X == 18 || X == 19 || X == 20 || X == 21 || X == 22 || X == 23 || X == 24)
                {
                Console.WriteLine("2nd 12 bets win");
            }
          else if (X == 25 || X == 26 || X == 27 || X == 28 || X == 29 || X == 30 || X == 31 || X == 32 || X == 33 || X == 34 || X == 35 || X == 36)
                {
                Console.WriteLine("3rd 12 bets win");
            }
        }
        public void CheckOddEven(int X)
        {
            if (X % 2 == 0)
            {
                Console.WriteLine("Even bets win");
            }
            else
            {
                 Console.WriteLine("Odd bets win"); 
            }
            
        }
        public void CheckColor(string color)
        {
            if (color == "Red")
            {
                Console.WriteLine($"Red bets win");
            }
            else
            {
                Console.WriteLine($"Black bets win");
            }
        }
        public void CheckHalf(int X)
        {

            if (X <= 18)
            {
                Console.WriteLine("1-18 bets win");
            }
            else
            {
                Console.WriteLine("19-36 bets win");
            }

        }



    }
}
