using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3
{
    public class Polynomial
    {

        private Fraction[] _coefficients { get; set; }

        public Polynomial()
        {
            _coefficients = new Fraction[0];
        }

        public Polynomial(Fraction[] coefficients)
        {
            _coefficients = coefficients;
        }

        public Polynomial(IEnumerable<Fraction> coefficients)
        {
            _coefficients = coefficients.Cast<Fraction>().ToArray();
        }

        public static Polynomial operator +(Polynomial p1, Polynomial p2)
        {
            var sum = p1._coefficients.Zip(p2._coefficients, (x, y) => x + y);
            return new Polynomial(sum);
        }

        public override string ToString()
        {
            var result = "";
            foreach (var item in _coefficients.Select((value, index) => new { value, index }))
            {
                result += item.value + "*x^" + item.index + "+";
            }
            return result.TrimEnd('+');
        }
    }
}
