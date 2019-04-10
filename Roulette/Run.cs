using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Run
    {
        Spin Spinnyboi = new Spin();
        bool running = true;
        Random RNG5 = new Random();
        Bets BetChecker = new Bets();
        

        static void Main(string[] args)
        {
            
            Run Runboi = new Run();
            Runboi.RunLoop();
        }
        
        public void RunLoop()
        {
            Spinnyboi.MakeResultsArrayNumbers();
            Spinnyboi.MakeResultsArrayColor();

            Console.WriteLine("Press enter to roll.");
            while (running == true)
            {

                var input = Console.ReadKey();

                switch (input.Key) //Switch on Key enum
                {
                    case ConsoleKey.Escape:
                        running = false;

                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Console.WriteLine("Press enter to roll.");
                        int IndexBoi = RNG5.Next(0, 37);

                        //Spinnyboi.CheckSpin(IndexBoi);

                        int retVal = (int)Spinnyboi.ReturnValue(IndexBoi);

                        string retCol = Spinnyboi.ReturnColor(IndexBoi);

                        BetChecker.CheckStuff(retVal, retCol);

                        Console.WriteLine($"Result is: {retVal}  ");

                       
                        break;


                    case ConsoleKey.UpArrow:
                        Spin Boi2 = new Spin();
                        Random RNG6 = new Random(Boi2.RandoMaker());
                        Console.WriteLine($" Seed result is: {Boi2.RandoMaker()} ");
                        Boi2.CheckSpin(RNG6.Next(0, 37));
                        Console.WriteLine($"Result is: {Boi2.spinResult}  ");
                        break;
                }

               
            }
        }
    }
}




        

