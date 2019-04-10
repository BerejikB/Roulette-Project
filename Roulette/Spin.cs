using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Roulette
{

    class Spin
    {
        string[] ResultsArray;
        string[] ResultsArrayColor;
        public int IndexBoi;
        Random RNG4 = new Random();
        
        public string spinResult;

        public int RandoMaker()
        {

            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] rndBytes = new byte[4];
            rng.GetBytes(rndBytes);
            int rand = BitConverter.ToInt32(rndBytes, 0);

            return rand;
        }
        public void MakeResultsArrayNumbers()
        {
            
            ResultsArray = new string[38];

            for (int i = 0; i < 36; i++)
                {
                ResultsArray[i] = i.ToString();
                }
            ResultsArray[37] = "00";

        }

        public void MakeResultsArrayColor()
        {

            ResultsArrayColor = new string[38];

            ResultsArrayColor[0] = "";
            ResultsArrayColor[1] = "Red";
            ResultsArrayColor[2] = "Black";
            ResultsArrayColor[3] = "Red";
            ResultsArrayColor[4] = "Black";
            ResultsArrayColor[5] = "Red";
            ResultsArrayColor[6] = "Black";
            ResultsArrayColor[7] = "Red";
            ResultsArrayColor[8] = "Black";
            ResultsArrayColor[9] = "Red";
            ResultsArrayColor[10] = "Black";
            ResultsArrayColor[11] = "Black";
            ResultsArrayColor[12] = "Red";
            ResultsArrayColor[13] = "Black";
            ResultsArrayColor[14] = "Red";
            ResultsArrayColor[15] = "Black";
            ResultsArrayColor[16] = "Red";
            ResultsArrayColor[17] = "Black";
            ResultsArrayColor[18] = "Red";
            ResultsArrayColor[19] = "Red";
            ResultsArrayColor[20] = "Black";
            ResultsArrayColor[21] = "Red";
            ResultsArrayColor[22] = "Black";
            ResultsArrayColor[23] = "Red";
            ResultsArrayColor[24] = "Black";
            ResultsArrayColor[25] = "Red";
            ResultsArrayColor[26] = "Black";
            ResultsArrayColor[27] = "Red";
            ResultsArrayColor[28] = "Black";
            ResultsArrayColor[29] = "Black";
            ResultsArrayColor[30] = "Red";
            ResultsArrayColor[31] = "Black";
            ResultsArrayColor[32] = "Red";
            ResultsArrayColor[33] = "Black";
            ResultsArrayColor[34] = "Red";
            ResultsArrayColor[35] = "Black";
            ResultsArrayColor[36] = "Red";
            ResultsArrayColor[37] = "";
   


        }

        public int ReturnValue(int X)
        {
           
            int val = int.Parse(ResultsArray[X]);
           
            return val;
        }

        public string ReturnColor(int X)
        {

            MakeResultsArrayColor();
            return ResultsArrayColor[X].ToString();

        }

        public void IndexModifier(int X)
        { IndexBoi = X; }

        public void CheckSpin(int X)
        {
            if (X <= 36)
            {
                spinResult = X.ToString();
            }

            else if (X > 36)
            {
                CheckSpinUpper36(X);
            }


        }

        public void CheckSpinUpper36(int X)
        {

            if (X == 37)
            {
                spinResult = "00";
            }

            else if (X == 38)
            {
                spinResult = "1st 12";
            }
            else if (X == 39)
            {
                spinResult = "2nd 12";
            }
            else if (X == 40)
            {
                spinResult = "3rd 12";
            }
            else if (X == 41)
            {
                spinResult = "1 to 18";
            }
            else if (X == 42)
            {
                spinResult = "Even";
            }
            else if (X == 43)
            {
                spinResult = "Red";
            }
            else if (X == 44)
            {
                spinResult = "Black";
            }
            else if (X == 45)
            {
                spinResult = "Odd";
            }
            else if (X == 46)
            {
                spinResult = "19-36";
            }
            else if (X == 47)
            {
                spinResult = "1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34";
            }
            else if (X == 48)
            {
                spinResult = "2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35";
            }
            else if (X == 49)
            {
                spinResult = "3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36";
            }















        }

        

        public void CheckBets()
        {




        }







    }
}
