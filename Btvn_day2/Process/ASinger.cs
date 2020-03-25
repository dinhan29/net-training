using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btvn_day2.Process
{
   public abstract class ASinger
    {
        protected string[] names = new string[] { "Son Tung MTP" , "Ho Ngoc Ha", "Bui Anh Tuan","Ho Hoai Anh", "Luu Huong Giang ","Huong Tram",
                "Dam Vinh Hung","Bao Anh", "Bich Phuong ","Ung Hoang Phuc","Bao Thy","Khoi My",
                "Dan Truong", "Erik","Duc Phuc","Ngo Kien Huy","Lam Truong","Hoa Minzy",
                "Only C", "Lou Hoang", "Uyen Linh","Hoang Yen","Bray","Amee",
                "Chau Dang Khoa ","Toc Tien", "Thuy Tien","Miu Le","Hong Nhung", "Issac"
            };
        public abstract int RandomAge();
        public string RandomName(string[] names)
        {
            Random r = new Random();
            int s = r.Next(0, names.Length - 1);
            return names[s];


        }
    }
}
