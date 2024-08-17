 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }
        
        public Child(int x, int y, int z):base(x , y)
        {
            Z = z;
        }

        public new int Product() // New Version Product Method 
        {
            return base.Product() * Z;
        }


        public override string ToString()
        {
            return $"({X} , {Y} , {Z})";
        }
    }
}
