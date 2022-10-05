using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    abstract class HotDrink
    {
        protected int sugar;
        protected double milk;
        public double Milk
        {
            get { return milk; }
            set { milk = value; }
        }
        public int Sugar
        {
            get { return sugar; }
            set { sugar = value; }
        }
        public void stringDrink()
        {
            Console.WriteLine("Напиток выпит");
        }
        public void AddMilk() { Console.WriteLine("Молоко добавлено: " + milk +" мл."); }
        public void AddSugar()
        {
            Console.WriteLine("Сахар добавлен: " + sugar + " кубиков");
        }
    }
}
