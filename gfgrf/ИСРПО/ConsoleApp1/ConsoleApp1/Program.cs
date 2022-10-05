using System;

namespace ConsoleApp1
{
    class Program
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
            public void printing()
            {
                Console.WriteLine("X(" + this.x + "," + this.y + "), " + this.z);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
          
            Angle ang = new Angle();
        ang.printing();
            Angle ang2 = new Angle(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine().ToCharArray()[0]);
        ang.printing();
        }
   
        
    }
}
