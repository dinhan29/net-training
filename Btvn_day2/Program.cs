using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Btvn_day2.Process;

namespace Btvn_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
             string[] arr = new string[] { "Son Tung MTP" , "Ho Ngoc Ha", "Bui Anh Tuan","Ho Hoai Anh", "Luu Huong Giang ","Huong Tram",
                "Dam Vinh Hung","Bao Anh", "Bich Phuong ","Ung Hoang Phuc","Bao Thy","Khoi My",
                "Dan Truong", "Erik","Duc Phuc","Ngo Kien Huy","Lam Truong","Hoa Minzy",
                "Only C", "Lou Hoang", "Uyen Linh","Hoang Yen","Bray","Amee",
                "Chau Dang Khoa ","Toc Tien", "Thuy Tien","Miu Le","Hong Nhung", "Issac"
            };
            //for (int i =0; i < arr.Count(); i++)
            //{
            //    Console.WriteLine(i+ 1+"       " + arr[i]);
            //}
   
            List<Singer> lSinger = new List<Singer>();
            // Cau 1 :Tạo một list 15 user được gán tên ngẫu nhiên từ danh sách trên và tuổi ngẫu nhiên trong khoảng 20 - 50
            Console.WriteLine("Cau 1");
            Random r = new Random();
            int count = 0;
           while (count <15) {  
                var s = r.Next(0, arr.Length - 1);
                if (!lSinger.Any(e=> e.Name == arr[s]))
                {
                    lSinger.Add(new Singer(arr[s], r.Next(20, 50)));
                    count++;
                }
                else { }


            }

           for (int i =0; i< lSinger.Count(); i++)
            {
                Console.WriteLine($" Ca Sy thu {i + 1} : {lSinger[i].Name} - {lSinger[i].Age} ");
            }
            // Cau 2: In ra tất cả các ca sỹ chứa từ khóa nhập vào
            Console.WriteLine("Cau 2");
            string keyword = "Bray";
            List<Singer> lName = lSinger.Where(e => e.Name.Contains(keyword)).ToList();
            for (int i =0; i < lName.Count; i++)
            {
                Console.WriteLine($" Ca Sy : {lName[i].Name} - {lName[i].Age} ");
            }
            if (lName.Count == 0)
            {
                Console.WriteLine($"Khong co ca sy trung ten voi {keyword}");
            }
            // Cau 3:  In ra các ca sỹ có tuổi lớn hơn 27
            Console.WriteLine("Cau 3");
            List<Singer> lAge = lSinger.Where(e => e.Age > 27).ToList();
            for (int i = 0; i < lAge.Count; i++)
            {
                Console.WriteLine($" Ca Sy : {lAge[i].Name} - {lAge[i].Age} ");
            }
            if (lAge.Count == 0)
            {
                Console.WriteLine($"Khong co ca sy lon tuoi hon 27");
            }
            // Cau 4 : In ra các ca sỹ có tên chứa từ khóa nhập vào và tuổi nhỏ hơn 25
            Console.WriteLine("Cau 4");
            List<Singer> lName_Age = lSinger.Where(e => e.Name.Contains(keyword) && e.Age < 25).ToList();
            for (int i = 0; i < lName_Age.Count; i++)
            {
                Console.WriteLine($" Ca Sy : {lName_Age[i].Name} - {lName_Age[i].Age} ");
            }
            if (lName_Age.Count == 0)
            {
                Console.WriteLine($"Khong co ca sy ");
            }
            Console.ReadLine();
        }
    }
}
