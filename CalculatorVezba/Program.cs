using System;

namespace CalculatorVezba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculator Casio = new Calculator();
            Casio.name = "Casio";
            Console.WriteLine(Casio.name);
            Console.WriteLine(Casio.soberi(5,3));
            Console.WriteLine(Casio.odzemi(6, 2));
            Console.WriteLine(Casio.pomnozi(3, 4));
            Console.WriteLine(Casio.podeli(20, 5));
            Console.WriteLine(Casio.EPogolemo(6, 5));
        }
    }
    class Calculator
    {
        public string name;

        void Main()
        {

        }
        public int soberi(int a, int b)
        {
            return a + b;

        }
        public int odzemi(int a, int b)
        {
            return a - b;
        }
        public int pomnozi(int a, int b)
        {
            return a * b;
        }
        public int podeli(int a, int b)
        {
            return a / b;
        }

        public bool EPogolemo(int a, int b)
        {
            return a > b;
        }
    }

}
