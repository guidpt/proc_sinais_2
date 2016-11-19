using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 
namespace proc_sinais_2.Helper
{
    public class Complex
    {
        public double real;
        public double imaginary;

        public Complex()
        {
            real = 0;
            imaginary = 0;
        }

        public Complex(double r, double i)
        {
            real = r;
            imaginary = i;
        }


        public static Complex from_polar(double r, double radians)
        {
            Complex data = new Complex(r * Math.Cos(radians), r * Math.Sin(radians));
            return data;
        }

        //Override addition operator 
        public static Complex operator +(Complex a, Complex b)
        {
            Complex data = new Complex(a.real + b.real, a.imaginary + b.imaginary);
            return data;
        }

        //Override subtraction operator  
        public static Complex operator -(Complex a, Complex b)
        {
            Complex data = new Complex(a.real - b.real, a.imaginary - b.imaginary);
            return data;
        }

        //Override multiplication operator
        public static Complex operator *(Complex a, Complex b)
        {
            Complex data = new Complex((a.real * b.real) - (a.imaginary * b.imaginary),
                (a.real * b.imaginary + (a.imaginary * b.real)));
            return data;
        }

        //Return magnitude of Complex number
        public double GetMagnitude()
        {
             return Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginary, 2));
        }

        public double GetPhase()
        {
            return Math.Atan(imaginary / real);
        }
    }
}