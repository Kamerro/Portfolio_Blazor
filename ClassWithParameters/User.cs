using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWithParameters
{
    public class User
    {
        private string Name { get; set; }
        private int Age { get; set; }
        private string Address { get; set; }
        public User(string name, int age, string address)
        {
            this.Name = name;
            this.Age = age;
            this.Address = address;
        }
        public string getName()
        {
            return this.Name;
        }
        public string getAddress()
        {
            return this.Address;
        }
        public int getAge()
        {
            return this.Age;
        }

    }
}
