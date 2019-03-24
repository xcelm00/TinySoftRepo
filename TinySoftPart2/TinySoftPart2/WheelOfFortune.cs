using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinySoftPart2
{
    public static class WheelOfFortune
    {
        public static int Multiplier;
        public static int Spin(int helper)
        {
            switch (helper)
            {
                case int n when helper > 0 && helper <= 80:
                    Multiplier = 0;
                    break;
                case int n when helper > 80 && helper <= 90:
                    Multiplier = 1;
                    break;
                case int n when helper > 90 && helper <= 97:
                    Multiplier = 10;
                    break;
                case int n when helper > 97 && helper <= 100:
                    Multiplier = 100;
                    break;
            }
            return Multiplier;
        }
    }
}
