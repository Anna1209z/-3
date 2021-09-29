using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лб_3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введiть перше число:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введiть номер дії:\n 1)+ \n 2)- \n 3)* \n 4):");
                    int oper = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введiть друге значення:");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Caculator cal = new Caculator(a, b, oper);
                    cal.AllOperations();
                }
                catch (Exception)
                {

                    Console.WriteLine("Виникла помилка!");
                }

            }


        }
    }
    class Caculator
    {
        public double a, b;
        public int oper;
        public Caculator(double a, double b, int oper)
        {
            this.a = a;
            this.b = b;
            this.oper = oper;
        }

        public void AllOperations()
        {
            if (oper == 1)
            {
               Console.WriteLine( GetSum(a,b));
            }
            else if (oper == 2)
            {
                Console.WriteLine (GetDifference(a,b));
            }
            else if (oper == 3)
            {
                Console.WriteLine(GetMultiplication(a, b));
            }
            else if(oper == 4)
            {
                Console.WriteLine(Getdivision(a, b));
            }
            else 
            {
                Console.WriteLine("Оберiть номер дiї iз вище зазначених: 1 або 2 або 3 або 4");
            }
           
        }
        public double GetSum(double a, double b)
        {
            return a + b;
        }

        public double GetDifference(double a, double b)
        {
            return a - b;
        }
        public double GetMultiplication(double a, double b)
        {
            return a * b;
        }
        public double Getdivision(double a, double b )
        {
            double result = 0;
            if (b != 0)
            {
                result += a / b;
            }
            else if (b == 0)
            {
                Console.WriteLine("На нуль дiлити не можна");
            }
            return  result;
        }
    }
}


