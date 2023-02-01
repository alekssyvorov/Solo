using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solo_11
{
    class Complicat
    {
        int level = 0;

        public Complicat(int level)
        {
            this.level = level;
        }

        public static int Level(int level)
        {
            int time = 0;
            if (level == 0)
            {
                time = 500;
            }
            else if (level == 1)
            {
                time = 300;
            }
            else if (level == 2)
                time = 50;
            return time;
        }
    }
}
