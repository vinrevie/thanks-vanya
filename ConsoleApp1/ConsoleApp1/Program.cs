using System;

namespace ConsoleApp1
{

    public class Program
    {

        static void Main(string[] args)
        {
            HotDrink dr = null;
            ICup cup = null;
            Console.WriteLine("Ведите тип напитка,Чай - 1, Кофе - 2");

            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                dr = new CupOfTea();

            }
            else if (choice == 2)
                dr = new CupOfCoffe();
            else
            {
                return;
            }

            Console.WriteLine("Введите тип стакана");
            string type = Console.ReadLine();
            (dr as ICup).Type = type;

            Console.WriteLine("Введите объем стакана");
            string capacity = Console.ReadLine();
            (dr as ICup).Capacity = capacity;

            if (choice == 1)
            {
                Console.WriteLine("Введите тип чая");
                string leafType = Console.ReadLine();
                (dr as CupOfTea).LeafType = leafType;
            }
            else if (choice == 2)
            {
                Console.WriteLine("Введите тип кофе");
                string beamType = Console.ReadLine();
                (dr as CupOfCoffe).BeamType = beamType;
            }
            Console.WriteLine("Ведите количество сахара (0-5)");

            try
            {
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount < 5 && amount > 0)
                    dr.AddSugar(amount);
                else
                    dr.AddSugar(0);
            }
            catch (Exception)
            {
                Console.WriteLine("Можно ввести только число");
            }
            Console.WriteLine("Ведите количество молока (0-5)");

            try
            {
                int amount = Convert.ToInt32(Console.ReadLine());
                if (amount < 5 && amount > 0)
                    dr.AddMilk(amount);
                else
                    dr.AddMilk(0);

            }
            catch (Exception)
            {
                Console.WriteLine("Можно ввести только число");
            }

            //Console.WriteLine("Ведите тип стаканчика");
            //string text = Convert.ToString(Console.ReadLine());
            //cup.type = text;
            //Console.WriteLine(text);
            ProcessCup(dr);

            Orders orders = new Orders();

            orders.itemname = "apples";
            orders.unitCount = 5;
            orders.unitCost = 5.45f;


            string orderText = "\n\n" + orders.itemname + " стоимость: " + orders.GetPrice();
            Console.WriteLine(orderText);

            Console.ReadKey();


        }
        static void ProcessCup(HotDrink hotDrink)
        {
            (hotDrink as ICup).Refill();
            (hotDrink as ICup).Wash();

            hotDrink.StringDrink();

            Console.WriteLine("Объем " + (hotDrink as ICup).Capacity);
        }

        struct Orders
        {
            public string itemname;  //наименование
            public int unitCount;       //числоединиц
            public float unitCost; //стоимостьоднойединицы


            public float GetPrice() 
            {
                return unitCount * unitCost;
            }
        }
    }
}
