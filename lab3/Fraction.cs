using System;
namespace lab3
{
    public class Fraction
    {
        private int _numerator { get; set; }
        private int _denominator { get; set; }

        public Fraction()
        {
        }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction(f1._numerator * f2._denominator + f2._numerator * f1._denominator, f1._denominator * f2._denominator);
        }

        public override string ToString()
        {
            return _numerator + "/" + _denominator;
        }
    }
}
