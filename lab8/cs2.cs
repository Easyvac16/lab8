using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8
{
    public struct ComplexNumber
    {
        public double Real { get; set; }  
        public double Imaginary { get; set; }  

        // Конструктор
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Додавання комплексних чисел
        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            double real = c1.Real + c2.Real;
            double imaginary = c1.Imaginary + c2.Imaginary;
            return new ComplexNumber(real, imaginary);
        }

        // Віднімання комплексних чисел
        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            double real = c1.Real - c2.Real;
            double imaginary = c1.Imaginary - c2.Imaginary;
            return new ComplexNumber(real, imaginary);
        }

        // Множення комплексних чисел
        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            double real = (c1.Real * c2.Real) - (c1.Imaginary * c2.Imaginary);
            double imaginary = (c1.Real * c2.Imaginary) + (c1.Imaginary * c2.Real);
            return new ComplexNumber(real, imaginary);
        }

        // Ділення комплексних чисел
        public static ComplexNumber operator /(ComplexNumber c1, ComplexNumber c2)
        {
            double denominator = (c2.Real * c2.Real) + (c2.Imaginary * c2.Imaginary);
            double real = ((c1.Real * c2.Real) + (c1.Imaginary * c2.Imaginary)) / denominator;
            double imaginary = ((c1.Imaginary * c2.Real) - (c1.Real * c2.Imaginary)) / denominator;
            return new ComplexNumber(real, imaginary);
        }
    }
    internal class cs2
    {
        public static void task_2()
        {
            ComplexNumber c1 = new ComplexNumber(2, 3);
            ComplexNumber c2 = new ComplexNumber(4, 5);

            ComplexNumber sum = c1 + c2;
            Console.WriteLine($"Сума: {sum.Real} + {sum.Imaginary}i");

            ComplexNumber difference = c1 - c2;
            Console.WriteLine($"Вiднiмання: {difference.Real} + {difference.Imaginary}i");

            ComplexNumber product = c1 * c2;
            Console.WriteLine($"Множення: {product.Real} + {product.Imaginary}i");

            ComplexNumber quotient = c1 / c2;
            Console.WriteLine($"Дiлення: {quotient.Real} + {quotient.Imaginary}i");

        }
    }
}
