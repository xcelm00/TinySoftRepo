using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TinySoftPart2
{
    class Program
    {
        static void Main(string[] args)
        {

            double kredit = 10000; //set for any value
            int multiplier = 0;
            double vyhra = 0;
            Random rand = new Random();

            //Please change the location of the logging file to desired location
            string path = @"C:\Users\Martin\Desktop\csv\log.txt"; //location of logging file

            #region CheckForFile
            using (var myFile = File.OpenWrite(path))             //check if file exists if it doesn't then create it

            {
            }
            #endregion
            #region CreateDelimiter
            using (var w = new StreamWriter(path, true))
            {
                w.WriteLine("-------------------------------");
                w.WriteLine("New Game");
                w.WriteLine("-------------------------------");
            }
            #endregion
            #region InitiateGame
            for (int i = 0; i < 9999; i++)
            {
                int helper = rand.Next(1, 100);

                //double bet = 0.05 * kredit; //5% kreditu
                double bet = 500; //500
                if (kredit - bet < 0)
                {
                    Console.WriteLine("Game Over after " + i + " spins");
                    break;
                }
                kredit -= bet;

                switch (helper)
                {
                    case int n when helper > 0 && helper<= 80:
                        multiplier = 0;
                        break;
                    case int n when helper> 80 && helper<= 90:
                        multiplier = 1;
                        break;
                    case int n when helper> 90 && helper<= 97:
                        multiplier = 10;
                        break;
                    case int n when helper> 97 && helper<= 100:
                        multiplier = 100;
                        break;
                }
                kredit += multiplier * bet;
                //Log the result
                using (var w = new StreamWriter(path, true))
                {
                    w.WriteLine(i + " " + kredit + " " + bet + " " + vyhra + " " + multiplier * bet + " " + multiplier);
                }
            }
            #endregion

        }
    }

}
