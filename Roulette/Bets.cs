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
            CheckStreet(X);
            CheckRow(X);

        }
        public void CheckSplit(int X)
        {
            int topSplit;
            int bottomSplit;
            int splitLeft;
            int splitRight;




            topSplit = X - 3;
            if (X == 0 ||  X < 4)
            {

            }
            else
            {
                Console.WriteLine($"Winning Split (top): {topSplit}");
            }

           
            bottomSplit = X + 3;

            if (X == 0 || X <= 4)
            {

            }
            else
            {
                Console.WriteLine($"Winning Split (bottom): {bottomSplit}");
            }
            
            //Left split dissalow
            //3 6 9 13 15 18 21 24 27 30 33 
            splitRight = X + 1;
            if ( X== 0 || X == 3 || X == 6 || X == 9 || X == 13 || X == 15 || X == 18 || X == 21 || X == 24 || X == 27 || X == 30 || X == 33)
            {

            }
            else
            {
                Console.WriteLine($"Winning split (Right): {splitRight}");
            }

            //Right split dissalow
            //4 7 10 13 16 19 22 25 28 31 34
            splitLeft = X - 1;
            if ( X == 0 || X == 4 || X == 7 || X == 10 || X == 13 || X == 16 || X == 19 || X == 22 || X == 25 || X == 28 || X == 31 || X == 34)

            {

            }
            else
            {
                Console.WriteLine($"Winning split (Left): {splitLeft} ");
            }

           // Console.WriteLine($"Winning split(s) {splitLeft}{splitRight}");
        }
        public void CheckCorner(int X)
        {
            if ( X == 2 || X == 5 || X == 8 || X == 11 || X == 14 || X == 17 || X == 20 || X == 23 || X == 26 || X == 29 || X == 32 || X == 35)
            {

                TopLeftCorner(X);
                TopRightCorner(X);
                BottomLeftCorner(X);
                BottomRightCorner(X);
            }
            //Right Side
            else if ( X == 3 || X == 6 || X == 9 || X == 12 || X == 15 || X == 18 || X == 21 || X == 24 || X == 27 || X == 30 || X == 33 || X == 36)
            {
                BottomLeftCorner(X);
                TopLeftCorner(X);

            }

            //Left Side
            else if( X == 1 || X == 4 || X == 7 || X == 10 || X == 13 || X == 16 || X == 19 || X == 22 || X == 25 || X == 28 || X == 31 || X == 34 )
            {
                TopRightCorner(X);
                BottomRightCorner(X);


            }
          

        }
        public void Check12(int X)
        {
            if (X == 1 || X == 2 || X == 3 || X == 4 || X == 5 || X == 6 || X == 7 || X == 8 || X == 9 || X == 10 || X == 11 || X == 12)
            {
                Console.WriteLine("Dozens: 1st dozen wins");
            }
           else if (X == 13 || X == 14 || X == 15 || X == 16 || X == 17 || X == 18 || X == 19 || X == 20 || X == 21 || X == 22 || X == 23 || X == 24)
                {
                Console.WriteLine("Dozens: 2nd dozen wins");
            }
          else if (X == 25 || X == 26 || X == 27 || X == 28 || X == 29 || X == 30 || X == 31 || X == 32 || X == 33 || X == 34 || X == 35 || X == 36)
                {
                Console.WriteLine("Dozens: 3rd dozen wins");
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
                Console.WriteLine("Lows 1-18 bets win");
            }
            else
            {
                Console.WriteLine("Highs 19-36 bets win");
            }

        }
     
        public void TopRightCorner(int X)
        {
            int up = X - 3;
            int right = X + 1;
            int rightUp = X - 2;
            Console.WriteLine($"Corners {up} {right} {rightUp} ");
        }

        public void TopLeftCorner(int X)
        {
            int leftUp = X - 4;
            int left = X - 1 ;
            int up = X - 3;
            Console.WriteLine($"Corners {up} {left} {leftUp} ");
        }

        public void BottomLeftCorner(int X)
        {

            int down = X + 3;
            int leftDown = X + 2 ;
            int left = X - 1;
            Console.WriteLine($"Corners {down} {left} {leftDown} ");
        }

        public void BottomRightCorner(int X)
        {
            if (true)
            {

            }
            int right = X + 1;
            int down = X + 3;
            int rightDown = X + 4;
            Console.WriteLine($"Corners {down} {right} {rightDown} ");
        }

        public void CheckStreet(int X)
        {

            if (X == 1 || X == 4 || X == 7 || X == 10 || X == 13 || X == 16 || X == 19 || X == 22 || X == 25 || X == 28 || X == 31 || X == 34)
            { Console.WriteLine($"First Column wins"); }
            else if (X == 2 || X == 5 || X == 8 || X == 11 || X == 14 || X == 17 || X == 20 || X == 23 || X == 26 || X == 29 || X == 32 || X == 35)

            { Console.WriteLine($"Second Column wins"); }

            else if (X == 3 || X == 6 || X == 9 || X == 12 || X == 15 || X == 18 || X == 21 || X == 24 || X == 27 || X == 30 || X == 33 || X == 36)
            { Console.WriteLine($"Third Column wins"); }
        }
        public void CheckRow(int X)
        {
            if (X == 1 || X == 2 || X == 3)
            {
                Console.WriteLine("Winning Row 1, 2, 3");
            }
            else if (X == 4 || X == 5 || X == 6)
            {

                Console.WriteLine("Winning Row 4, 5, 6");
            }
            else if (X == 7 || X == 8 || X == 9)
            {

                Console.WriteLine("Winning Row 7, 8, 9");
            }
            else if (X == 10 || X == 11 || X == 12)
            {
                Console.WriteLine("Winning Row 10, 11, 12");
            }
            else if (X == 13 || X == 14 || X == 15)
            {

                Console.WriteLine("Winning Row 13, 14, 15");
            }
            else if (X == 16 || X == 17 || X == 18)
            {

                Console.WriteLine("Winning Row 16, 17, 18 ");
            }
            else if (X == 19 || X == 20 || X == 21)
            {

                Console.WriteLine("Winning Row 19, 20, 21");
            }
            else if (X == 22 || X == 23 || X == 24)
            {

                Console.WriteLine("Winning Row 22, 23, 24");
            }
            else if (X == 25 || X == 26 || X == 27)
            {

                Console.WriteLine("Winning Row 25, 26, 27");
            }
            else if (X == 28 || X == 29 || X == 30)
            {

                Console.WriteLine("Winning Row 28, 29, 30");
            }
            else if (X == 31 || X == 32 || X == 33)
            {
                Console.WriteLine("Winning Row 31, 32, 33");
            }
            else if (X == 34 || X == 35 || X == 36)
            {

                Console.WriteLine("Winning Row 34, 35, 36");
            }


        }

        public void CheckDoubleRow(int X)
        {








        }
    }
}
