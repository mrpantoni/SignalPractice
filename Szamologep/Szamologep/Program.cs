using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szamologep
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = 0;
            double secondNum = 0;
            char operand = ' ';

            Console.WriteLine("Add meg az első számot:");
            firstNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a második számot:");
            secondNum = double.Parse(Console.ReadLine());

            Console.WriteLine("Add meg a műveleti jelet ( +, -, *, / )");
            operand = Convert.ToChar(Console.Read());
            
            double result = 0;
            switch (operand)
            {
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
                case '*':
                    result = firstNum * secondNum;
                    break;
                case '/':
                        result = firstNum / secondNum;
                        break;
                default: throw new ArgumentException("Nem megfelelő műveleti jel!");
            }

            Console.WriteLine($"Az eredmény: {result}");
            Console.ReadKey();
        }
    }
}
