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
            double vyhra = 0;
            Random rand = new Random();

            //Please change the location of the logging file to desired location
            string path = @"C:\Users\Martin\Desktop\log.txt"; //location of logging file

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

                WheelOfFortune.Spin(helper);

                kredit += WheelOfFortune.Multiplier * bet;
                
                //Log the result
                using (var w = new StreamWriter(path, true))
                {
                    w.WriteLine(i + " " + kredit + " " + bet + " " + vyhra + " " + WheelOfFortune.Multiplier * bet + " " + WheelOfFortune.Multiplier);
                }
            }
            #endregion
        }
    }



}
