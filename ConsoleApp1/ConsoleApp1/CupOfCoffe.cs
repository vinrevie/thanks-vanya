using System;

namespace ConsoleApp1
{
    class CupOfCoffe : HotDrink , ICup
    {
       public void Refill()
        {
            Console.WriteLine("стакан наполнен заново");
        }
        public void Wash()
        {
            Console.WriteLine("стакан вымыт");
        }
        string type;
        string capacity;
        string beamType;

        public string Type
        {
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
        public string BeamType
        {
            get
            {
                return beamType;
            }
            set
            {
                if (value == "арабика" || value == "барбарис")
                    beamType = value;
                else throw new Exception("incorrect beam type");
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
            Console.WriteLine("ваш напиток - Coffe");
            Console.WriteLine("тип стаканчика" + type);
            Console.WriteLine("объем стаканчика: " + capacity);
            Console.WriteLine("тип зерен: "  + beamType);
            Console.WriteLine("milk: " + milk);
            Console.WriteLine("sugar: " + sugar);
            Console.ReadKey();
        }
    }
}
