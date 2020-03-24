using net_training.Process;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            
            //  FindMax();
            // Sort();
            // Day2Max();
            var day2 = new Day2();
            int[] arr = new int[] { 1, 2, 3, 6, 9, 0 };
            
            User[] arrUser = new User[] {
                new User("Nguyen Xuan Phuc","123",45,"a@","zx"),
                new User("Trong Phu Nguyen","1234",45,"b@","zxy"),
                new User("Vu Duc Dam","12345",84,"c@","zxasy"),
                new User("Huynh Duc Tho","12346",18,"b@","zxy"),
            };
            
            //arrUser[0] = null;

            var gh = arrUser.ToList();// ???
          
          
            
            List<User> lusers = new List<User>();// tao mang kieu du lieu User 
            //for(int i =0; i<30; i++) lusers.Add(new User("User "+i));
            lusers.AddRange(arrUser);// Noi hai mang 
            //   lusers[0].Name = "abc";
            List<User> lage = lusers.Where(u => u.Age == 45).ToList();
            var query = (from u in lusers where u.Age == 45 select u).FirstOrDefault();// Tim nguoi dau tien neu Null thi bao null
            for (int i = 0; i < lage.Count(); i++)
            {
                //  User abc = lusers.ElementAt(i);
                // abc.Display();
                lage[i].Display();
            }
            //     var newarr = arrUser.Where(u => (!u.Name.StartsWith("Nguyen")));
            //     Console.WriteLine(newarr.Count());

            //for (int i = 0; i < lusers.Count(); i++)
            //{
            //    //  User abc = lusers.ElementAt(i);
            //    // abc.Display();
            //    lusers[i].Display();
            //}

            //for (int i = 0; i < arrUser.Length; i++)
            //{
            //    User abc = arrUser[i];
            //    string[] ten = abc.Name.Split(' ');
            //    // abc.Display();
            //    if (ten[ten.Length - 1] == "Nguyen")
            //    {
            //        abc.Display();
            //    }
            //}

            Console.WriteLine("hello");
            day2.sortAsc(arr);
            Console.WriteLine("hello");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }
            Console.ReadLine();
        }
        public static void FindMax()
        {
            int[] arr = new int[] { 3, 4, 5, 7, 3, 8, 0, 4 };
            /* for (int i = 0; i < arr.Length; i++)
              {
                  Console.Write(arr[i]);
              }*/
            int m = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (m < arr[i])
                {
                    m = arr[i];
                }
            }
            Console.WriteLine(m);

        }

        public static void Sort()
        {
            int[] arr = new int[] { 3, 4, 5, 7, 3, 8, 0, 4, 9 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var tem = arr[j];
                        arr[j] = arr[i];
                        arr[i] = tem;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
            }

        }

        public static void day1()
        {
            /*  var a = new User();
            a.Name = "AN";
            a.Display();
            User b = new User(a.Name); // => 123
            b.Display();
            var c = b; // => 123
            c.Display();
            a.Name = "DIeu";
            a.Display();
            b.Display();
            c.Display();
            b.Name = "Jacob";
            a.Display();
            b.Display();
            c.Display();
            // Khai bao kieu du lieu la user , dung chung bo nho
            // cac bieu kieu primative - nguyen tthuy
            int ia = 1;
            Console.WriteLine(ia); // = 1
            int ib = ia;
            Console.WriteLine(ib); // = 1
            int ic = ib;
            Console.WriteLine(ic);// = 1
            ia = 2;
            Console.WriteLine(ia); // = 2
            Console.WriteLine(ib); // = 1
            Console.WriteLine(ic); // = 1
            */
            //day2
            var day2 = new Day2();
            Console.WriteLine(day2.minus(1, 3));
            Console.WriteLine(day2.multi(1, 3));
            Console.WriteLine(day2.sub(1, 3));
            Console.WriteLine(day2.sum(1, 3));

        }
        public static void Day2Max()
        {
            var day2 = new Day2();
            int[] arr = new int[] { 1, 2, 3, 6 };
            Console.WriteLine(day2.max(new int[] { 1, 2, 3, 6 }));
        }
    }
}
