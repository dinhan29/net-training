using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Btvn_day2.Process;
using Newtonsoft.Json;
using System.IO;

namespace Btvn_day2
{
    class Program
    {
        static void Main(string[] args)
        {


            List<Singer> lSinger = new List<Singer>();
            int count = 0;
            while (count < 1000)
            {
                Singer singer = new Singer();
                lSinger.Add(singer);
                count++;
            }

            var data = JsonConvert.SerializeObject(lSinger); // du lieu phai duocj ghi ra file_btvn.txt
                                                             // SerializeObject chuyển dữ liệu từ lSinger sang kiểu dữ liệu Json và DeserializeObject ngược lại
                                                             // doc tu file file_btvn.txt
            string datafromFile = @"D:\file_btvn.txt";
            var fs1 = new FileStream(datafromFile, FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter str1 = new StreamWriter(fs1);
            str1.WriteLine(data);
            str1.Close();
            fs1.Close();

            //string datafromFile = @"D:\file_btvn.txt";
            //var fs = new FileStream(datafromFile, FileMode.Open, FileAccess.Read, FileShare.None);// mở file 
            //StreamReader str = new StreamReader(fs);// đọc file 
            //string sb = str.ReadLine();// ghi file vào biến
            //var readDataFromDB = JsonConvert.DeserializeObject<List<Singer>>(sb);
            //for (int i = 0; i < readDataFromDB.Count; i++)
            //{
            //    readDataFromDB[i].Display();
            //}
            //fs.Close();
            //str.Close();

            //  Console.WriteLine(data);

            Console.ReadLine();
        }
    }
}
