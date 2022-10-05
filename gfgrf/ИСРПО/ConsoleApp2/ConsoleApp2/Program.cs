using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        

    static void ProcessCup(HotDrink drink)
        {
            
       
            
            if (drink is CupOfTea)
            {
                
                CupOfCoffee d = (CupOfCoffee)drink;
                (drink as CupOfTea).LEafType = "";
                drink.AddMilk();


            }
            if (drink is CupOfCoffee)
            {
                CupOfTea d = (CupOfTea)drink;
           
                (drink as CupOfTea).LEafType = "";

            }
            else
            {
                Console.WriteLine("Ошибка");
            }
           // d.AddMilk();
            drink.AddMilk();
            drink.AddSugar();
            (drink as ICup).Type = "пластик";
            (drink as ICup).Capacity = 0.5;
            drink.stringDrink();
            (drink as ICup).Refill();
            (drink as ICup).Wash();
            drink.stringDrink();
        }
        struct structorders
        {
            string publicstringitemname;  //наименование
            int publicintunitCount;       //числоединиц
            int publicdoubleunitCost; //стоимостьоднойединицы
        }
        static void Main(string[] args)
        {
          
            //Console.WriteLine("Задание 1");

            //Angle ang = new Angle();
            //ang.printing();
            //Console.WriteLine("Введите координаты:");
            //ang.Adding(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine().ToCharArray()[0]);
            //Console.WriteLine("Введите координаты угла №2");
            //Angle ang2 = new Angle(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()), Console.ReadLine().ToCharArray()[0]);
            //ang2.printing();
            HotDrink drink;
            Console.WriteLine("Задание №2");
            Console.WriteLine(" Чай или кофе?");
            if (Console.ReadLine() == "чай")
            {
                drink = new CupOfCoffee();
            }
            if (Console.ReadLine() == "чай")
            {
                drink = new CupOfTea();
            }
            Console.WriteLine("");

            Console.ReadKey();
        }


    
 
    }
}
