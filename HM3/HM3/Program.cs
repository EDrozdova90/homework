using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM3 { }
class Complex
{
     double im;
     double re;
    public Complex(double Re, double Im)
    {
        this.re = Re;
        this.im = Im;
    }
    public Complex()
    {
        this.re = 0;
        this.im = 0;
    }
    // Сложение комплексных чисел 
    public Complex Plus(Complex x2)
    {
        return new Complex(x2.re + this.re, x2.im + this.im);
    }
    static public Complex Plus(Complex x1, Complex x2)
    {
        return new Complex(x2.re + x1.re, x2.im + x1.im);
    }

    public string Plus()
    {
        return $"{re} + {im}i";
    }
    //Вычитание комплексных чисел 

    public Complex Minus(Complex x6)
    {
        return new Complex(x6.re + this.re, x6.im + this.im);
    }

    static public Complex Minus(Complex x5, Complex x6)
    {
        return new Complex(x5.re - x6.re, x5.im - x6.im);
    }

    public string Minus()
    {
        return $"{re} - {im}i";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Complex x1 = new Complex(2, 3);
        Complex x2 = new Complex(4, 5);
        Complex x3 = new Complex();

        x3 = Complex.Plus(x1, x2);
        Console.WriteLine(x3.Plus());

        // Добавление метода вычитания 

        Complex x5 = new Complex(8, 6);
        Complex x6 = new Complex(6, 2);
        Complex x7 = new Complex();

        x7 = Complex.Minus(x5, x6);
        Console.WriteLine(x7.Minus());

        Console.ReadLine();



        //так и не дошло как в Сами числа и сумму вывести на экран, используя tryParse
        int sum = 0;
        int num = 0;


        do
        {
            num = int.Parse(Console.ReadLine());
            if (num > 0 && num % 2 == 1)
                sum += num;

        } while (num != 0);

        Console.WriteLine("Sum: " + sum);
    }
}

