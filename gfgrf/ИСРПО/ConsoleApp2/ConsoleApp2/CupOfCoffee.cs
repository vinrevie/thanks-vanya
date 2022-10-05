using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CupOfCoffee: HotDrink,  ICup
    {
        string BeanType;
        string type;
        double capacity;



        string ICup.Type { get { return type; }set { type = value; } }
        double ICup.Capacity { get { return capacity; } set { capacity = value; } }
        // get => throw new NotImplementedException();
        public string BEanType
        {
            get { return BeanType; }
            set { BeanType = value; }
        }

        void ICup.Refill()
        {
            Console.WriteLine("Чашка заполнена");
            throw new NotImplementedException();
        }

        void ICup.Wash()
        {
            Console.WriteLine("Чашка вымыта");
           // throw new NotImplementedException();
        }
        public void ShowInfo()
        {
            Console.WriteLine("ВАш напиток - кофе");
            Console.WriteLine("Тип зерен кофе: " + BeanType);
            Console.WriteLine("Тип стакана: " + type);
            Console.WriteLine("Объем стакана: " + capacity);
            Console.WriteLine("Количество молока" + milk);
            Console.WriteLine("Количество сахара" + sugar);

        }
    }
}
