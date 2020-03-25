using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btvn_day2.Process
{
    public interface ISinger
    {
        void Display();
        bool IsYoung();
        string RandomName();
    }
}
