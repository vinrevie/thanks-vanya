namespace ConsoleApp1
{
    interface ICup
    {
        void Refill();
        void Wash();
 
        string Type { get; set; }
        string Capacity { get; set; }
    }
}
