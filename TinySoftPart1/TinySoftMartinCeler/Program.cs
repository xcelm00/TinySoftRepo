using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TinySoftMartinCeler
{
    class Program
    {
        static void Main(string[] args)
        {


            Random rand = new Random();
            //int winNumber = 0;
            int chance = rand.Next(1, 100);

            #region InitiateGame
            WheelOfFortune.Spin(chance);
            #endregion

            Console.WriteLine("And the number is " + WheelOfFortune.winNumber + "!!!");
            Console.ReadKey();
        }
    }

    

    
}
