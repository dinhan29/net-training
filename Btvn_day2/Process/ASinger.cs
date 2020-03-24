using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btvn_day2.Process
{
   public abstract class ASinger
    {
        public abstract int RandomAge();
        public string RandomName(string[] names)
        {
            Random r = new Random();
            int s = r.Next(0, names.Length - 1);
            return names[s];


        }
    }
}
