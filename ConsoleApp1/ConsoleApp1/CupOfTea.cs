using System;

namespace ConsoleApp1
{
    class CupOfTea: HotDrink, ICup
    {
        public void Refill()
        {
            Console.WriteLine("стакан наполнен заново");
        }
        public void Wash()
        {
            Console.WriteLine("стакан помыт");
        }
        string type;
        string capacity;
        string leafType;

        public string LeafType
        {
            get
            {
                return leafType;
            }
            set
            {
                if (value == "зеленый" || value == "черный")
                    leafType = value;
                else throw new Exception("incorrect чай type");
            }
        }
        public string Type {
            get
            {
                return type;
            }
            set
            {
                if (value == "пластик" || value == "стакан")
                    type = value;
                else throw new Exception("incorrect стакан type");
            }
        }
        public string Capacity
        {
            get
            {
                return capacity;
            }
            set
            {
                if (value == "0.3" || value == "0.5" || value == "0.7")
                    capacity = value;
                else throw new Exception("incorrect capacity type");
            }
        }

        public override void AddSugar(int a)
        {
            sugar = a;
        }
        public override void AddMilk(int a)
        {
            milk = a;
        }
        public override void StringDrink()
        {
            Console.WriteLine("ваш напиток - Tea");
            Console.WriteLine("тип стаканчика" + type);
            Console.WriteLine("объем стаканчика: " + capacity);
            Console.WriteLine("Вид чая: " + leafType);
            Console.WriteLine("milk: " + milk);
            Console.WriteLine("sugar: " + sugar);
            Console.ReadKey();
        }
    }
}
