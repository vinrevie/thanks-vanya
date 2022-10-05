using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class CupOfTea: HotDrink, ICup
    {
        string LeafType;
        string type;
        double capacity;

       public  string LEafType
        {
            get { return LeafType; }
            set { LeafType = value; }
        }

        string ICup.Type { get { return type; } set { type = value; } }
        double ICup.Capacity { get { return capacity; } set { capacity = value; } }
        // get => throw new NotImplementedException();
        void ICup.Refill()
        {
            Console.WriteLine("Чашка заполнена");
            throw new NotImplementedException();
        }

        void ICup.Wash()
        {
            Console.WriteLine("Чашка вымыта");
            throw new NotImplementedException();
        }
        public void ShowInfo()
        {
            Console.WriteLine("ВАш напиток - чай");
            Console.WriteLine("Тип листьев чая - " +  LeafType);
            Console.WriteLine("Тип стакана: " + type);
            Console.WriteLine("Объем стакана: " + capacity);
            Console.WriteLine("Количество молока" + milk);
            Console.WriteLine("Количество сахара" + sugar);
            
        }
    }
}
