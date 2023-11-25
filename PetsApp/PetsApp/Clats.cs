using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsApp
{
    public class Cat
    {
        private string name;
        private string owner;

        public Cat(string n, string o)//constructor
        {
            name = n;
            owner = o;
        }
        public void showCat()
        {
            MessageBox.Show(name + " says moew to " + owner);
        }
    }
}
