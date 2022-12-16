using System;

namespace Lesson7_SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b1, b2;
            //b1 = new Bank();

            b1 = Bank.Instance;
            b1.Hafkada(1000);

            b2 = Bank.Instance;
            b2.Hafkada(300);
        }
    }
}
