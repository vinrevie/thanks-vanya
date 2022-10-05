using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Angle
    {
        int x;
        float y;
        char z;
        public Angle()
        {
            x = 0;
            y = 0;
            z = 'S';
        }
        public Angle(int X, float Y, char Z)
        {
            x = X;
            y = Y;
            z = Z;
        }
        public void Adding(int X, float Y, char Z)
        {

            x = X;
            y = Y;
            z = Z;
         
        }
        public void printing()
        {
            Console.WriteLine("X(" + this.x + "," + this.y + "), " + this.z);
        }
    }
  
}
