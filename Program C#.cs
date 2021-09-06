using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, result;
            try
            {
                Console.Write("введите первое число: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("введите второе число: ");
                b = Convert.ToDouble( Console.ReadLine());
                if (b == 0) throw new DivideByZeroException();
                Console.WriteLine("результат: " + (result = a / b));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("деление на 0 не предусмотрено");
            }

            catch (FormatException)
            {
                Console.WriteLine("введено неверное значение");
            }
            catch 
            {
                Console.WriteLine("неизвестная ошибка операции");
            }

            Console.WriteLine();
            Console.WriteLine("размер типа данных int равен " + sizeof(int) + " bytes");
            Console.WriteLine("размер типа данных float равен " + sizeof(float) + " bytes");
            Console.ReadKey();
            }
    }
}
