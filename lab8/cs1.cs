using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    struct Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator + b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator - b.Numerator * a.Denominator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Numerator;
            int denominator = a.Denominator * b.Denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            int numerator = a.Numerator * b.Denominator;
            int denominator = a.Denominator * b.Numerator;
            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }

    internal class cs1
    {
        public static void task_1()
        {
            Fraction a = new Fraction(1, 2);
            Fraction b = new Fraction(3, 4);

            Fraction c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");

            Fraction d = a - b;
            Console.WriteLine($"{a} - {b} = {d}");

            Fraction e = a * b;
            Console.WriteLine($"{a} * {b} = {e}");

            Fraction f = a / b;
            Console.WriteLine($"{a} / {b} = {f}");
        }

    }
}
