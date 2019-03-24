using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinySoftMartinCeler
{
    public static class WheelOfFortune
    {
        public static int winNumber;

        public static int Spin(int chance)
        {
            switch (chance)
            {
                case int n when chance > 0 && chance <= 25:
                    winNumber = 10;
                    break;
                case int n when chance > 25 && chance <= 47:
                    winNumber = 9;
                    break;
                case int n when chance > 47 && chance <= 62:
                    winNumber = 8;
                    break;
                case int n when chance > 62 && chance <= 73:
                    winNumber = 7;
                    break;
                case int n when chance > 73 && chance <= 82:
                    winNumber = 6;
                    break;
                case int n when chance > 82 && chance <= 89:
                    winNumber = 5;
                    break;
                case int n when chance > 89 && chance <= 94:
                    winNumber = 4;
                    break;
                case int n when chance > 94 && chance <= 97:
                    winNumber = 3;
                    break;
                case int n when chance > 97 && chance <= 99:
                    winNumber = 2;
                    break;
                case int n when chance > 99 && chance <= 100:
                    winNumber = 1;
                    break;
            }
            return winNumber;
        }

    }
}
