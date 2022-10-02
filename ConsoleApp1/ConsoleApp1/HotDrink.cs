namespace ConsoleApp1
{
    abstract class HotDrink
    {
        protected int sugar = 1;
        protected int milk = 1;

        public abstract void StringDrink();
        public abstract void AddMilk(int milk);
        public abstract void AddSugar(int sugar);
    }
}
