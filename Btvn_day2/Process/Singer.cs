using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Btvn_day2.Process
{
   public class Singer : ASinger, ISinger 
    {
        
        public Singer(string name, int age) {
            Name = name;
            Age = age;
        }
        public Singer() {
            Name = RandomName();
            Age = RandomAge();
        }
        
        public string Name { get; set; }
        public int Age { get; set; }
        public void Display()
        {

            Console.WriteLine($"Ca Sy : {Name},{Age}");
        }

        public bool IsYoung()
        {
            //if(Age < 30)
            //{
            //    return true;
            //}else
            //{
            //    return false;
            //}
            return Age < 30;
            
        }

        public override int RandomAge()
        {
            return RandomAge(20,50);
        }
        public int RandomAge(int min , int max)
        {
            return new Random().Next(min, max);
        }
        

        public string RandomName()
        {
            Random r = new Random();
            int s = r.Next(0, names.Length - 1);
            return names[s];
        }
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
    }
}
