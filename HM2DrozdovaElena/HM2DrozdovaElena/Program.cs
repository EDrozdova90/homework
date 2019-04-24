using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM2DrozdovaElena
{
    class Program
    {
        static void Main(string[] args)
        {

            //минимальное из 3 чисел
            int b, c, d;
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            int min = b;
            if (c < min) min = c;
            if (d < min) min = d;
            Console.WriteLine("min" + min);

            // подсчет цифр введеного числа
            Console.Write("Введите число ");
            int a = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (a > 0)
            {
                i++;
                a /= 10;
            }
            Console.WriteLine("Количество цифр введенного числа = {0}", i);

            //С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел
            int sum = 0;
            int num = 0;
            Console.WriteLine("Вводите цисла,пока не будет введен 0");
            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                    sum += num;


            } while (num != 0);

            Console.WriteLine("Сумма нечетных чисел " + sum);
            // Ввод логин и пароль,3 попытки
            string login = "Elena";
            string Password = "Drozdova";
            int count = 0;
            do
            {
                Console.WriteLine("Введите логин: ");
                string login2 = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string Password2 = Console.ReadLine();
                if (login == login2 && Password == Password2)
                {

                    Console.WriteLine("Добро пожаловать");
                    Console.ReadLine();
                    break;
                }
                Console.WriteLine("Неверно введен логин или пароль");
                Console.ReadLine();
                ++count;
            } while (count < 3);

            Console.ReadKey();
        }
        }
    }


  

