using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net_training.Process
{
    public class User
    {
        private string _name;// 
        // constructor 
        public User() {
            Console.WriteLine("init  user project");
            _name = "an";
            

        }// overload 1
        public User (string name)
        {
            _name = name;
        }// overload 2
        public User (string name, string sdt, int age, string email, string address)
        {
            _name = name;
            Mobile = sdt;
            Email = email;
            Address = address;
            Age = age;
        }
        // prop tab tab
        private string IsStudent { get; set; }
        public int Age { get; set; }
        public string Name {
            get
            {
                if (string.IsNullOrEmpty(_name))
                {
                    return "an";
                }
                else
                {
                    return _name;
                }
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _name = "dieu";

                }
                else
                {
                    _name = value;
                }
            }
        }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string  Address { get; set; }
        public void Display()
        {
            Console.WriteLine($"Value of User is {Name}, {Mobile},{Age},{Email},{Address}");
        }


    }
}
