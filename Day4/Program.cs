using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        public static string[] names = new string[] { "Son Tung MTP" , "Ho Ngoc Ha", "Bui Anh Tuan","Ho Hoai Anh", "Luu Huong Giang ","Huong Tram",
                "Dam Vinh Hung","Bao Anh", "Bich Phuong ","Ung Hoang Phuc","Bao Thy","Khoi My",
                "Dan Truong", "Erik","Duc Phuc","Ngo Kien Huy","Lam Truong","Hoa Minzy",
                "Only C", "Lou Hoang", "Uyen Linh","Hoang Yen","Bray","Amee",
                "Chau Dang Khoa ","Toc Tien", "Thuy Tien","Miu Le","Hong Nhung", "Issac"
            };
        private static readonly Random random = new Random();
        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return random.Next(min, max);
            }
        }
        static void Main(string[] args)
        {
            DeQuy(4);
            List<User> lUser = new List<User>();
            int count = 0;
            while(count < 500)
            {
                User user = new User();
                user.Age = RandomNumber(20, 50);
                user.Name = names[RandomNumber(0, names.Length - 1)];
                lUser.Add(user);
                count++;
                //user.Display();
            }
            var query = lUser.GroupBy(e => new { e.Name, e.Age }).Select(e => new { e.Key.Name, e.Key.Age, count = e.Count() });
            foreach (var item in query)
            {
           //     Console.WriteLine($"{item.Name} {item.Age} , {item.count}");
                
            }
            DirectoryInfo d = new DirectoryInfo(@"D:\training");//Assuming Test is your Folder
            DisplayInfo(@"D:\training");

            Console.ReadLine();

        }

        public static void DisplayInfo(string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);//Assuming Test is your Folder
            var Files = d.GetFileSystemInfos(); //Getting Text files
           // string str = "";
            foreach (var item in Files)
            {
                // str = str + ", " + file.Name;
                if (item.Attributes.HasFlag(FileAttributes.Directory))
                {
                    Console.WriteLine($"Thu muc: {path}\\{item.Name}");
                    DisplayInfo($"{path}\\{item.Name}");

                } else
                {
                    Console.WriteLine($"File:{path}\\{item.Name}");
                }
               
            }
        }

        public static void DeQuy( int number)
        {
            if (number == 0) {
            }
            else
            {
                Console.WriteLine($"Hello");
                DeQuy(number - 1);
            }

        }
       
    } 
}
