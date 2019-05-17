using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _55555
{
    class Program
    {
        static void Main(string[] args)
        {// проверка является ли строка перестановкой другой
            string s1 = Convert.ToString(Console.ReadLine());
            string s2 = Convert.ToString(Console.ReadLine());
            if (s1.Select(Char.ToUpper).OrderBy(x => x).SequenceEqual(s2.Select(Char.ToUpper).OrderBy(x => x)))
            {
                Console.WriteLine("true");
            }
            else { Console.WriteLine("false"); }
            // проверка коректного логина

            Regex login_regex = new Regex("^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");
            string source = Console.ReadLine();

            if (login_regex.Match(source).Success) // если совпадение удачно
            {
                Console.WriteLine("Login is correct");
            }
            else
            {
                Console.WriteLine("Login is incorrect");
            }
            Console.ReadKey();
        }
    }
}
