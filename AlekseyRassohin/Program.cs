using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlekseyRassohin
{
    class Program
    {
        static void Main(string[] args)
        {

            //Объявляем переменные z1 и z2, они будут хранить результат
            double z1, z2;

            //Получаем от пользователя число для подстановки в формулу
            Console.WriteLine("Лабораторная работа №1. Вариант 24");
            Console.WriteLine("Введите любое число (целое, дробное, положительное, отрицательное, и программа выдаст результат по двум формулам из задания)");
            double a = Convert.ToDouble(Console.ReadLine());

            //Считаем по формуле, если получается – выводим результат, если нет – сообщаем об ошибке
            try
            {

                //Тут мы просто пользуемся Стандартными функциями из встроенного класса Match
                z1 = (Math.Sin((Math.PI / 2) + 3*a)) / (1 - Math.Sin(3*a - Math.PI));

                //В математике котангенс обратен тангенсу, поэтому делим 1 на Tan
                z2 = 1 / Math.Tan((5d/4d) * Math.PI + (3d/2d) * a);
                Console.WriteLine("Ура, я молодец!");

                Console.WriteLine("z1 получился " + z1);
                Console.WriteLine("z2 получился " + z2);
            }
            catch
            {
                Console.WriteLine("Увы, произошла ошибка! :(");
            }

            Console.Read();
        }
    }
}
