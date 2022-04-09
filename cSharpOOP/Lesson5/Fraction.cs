using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpOOP.Lesson5
{
    internal class Fraction
    {
        private int _divident, _devisor;

        public Fraction(int divident, int devisor)
        {
            if (devisor == 0)
                throw new ArgumentException("Divisor cannot be zero");
            if (divident < 0 && devisor < 0)
            {
                divident *= -1;
                devisor *= -1;
            }
            _divident = divident;
            _devisor = devisor;
            Reduction();
        }

        public Fraction(double decimalFractionNumber)
        {
            int factor = 1;
            while (decimalFractionNumber % 1 > 0)
            {
                decimalFractionNumber *= 10;
                factor *= 10;
            }
            _divident = (int) decimalFractionNumber;
            _devisor = factor;
            Reduction();
        }

        /* Сокращение дробей */
        private void Reduction()
        {
            for (int i = Math.Min(Math.Abs(_divident), Math.Abs(_devisor)); i > 1; i--)
            {
                if (_divident % i == 0 && _devisor % i == 0)
                {
                    _divident /= i;
                    _devisor /= i;
                    return ;
                }
            }
        }

        public override string ToString() => _divident + "/" + _devisor;

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Fraction))
                return this == (Fraction)obj;
            return false;
        }

        public static bool operator ==(Fraction f1, Fraction f2)
        {
            return f1._divident * f2._devisor == f2._divident * f1._devisor;
        }

        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return ! (f1._divident * f2._devisor == f2._divident * f1._devisor);
        }

        public static bool operator >(Fraction f1, Fraction f2)
        {
            return f1._divident * f2._devisor > f2._divident * f1._devisor;
        }
        
        public static bool operator <(Fraction f1, Fraction f2)
        {
            return f1._divident * f2._devisor < f2._divident * f1._devisor;
        }
        
        public static bool operator >=(Fraction f1, Fraction f2)
        {
            return f1._divident * f2._devisor >= f2._divident * f1._devisor;
        }
        
        public static bool operator <=(Fraction f1, Fraction f2)
        {
            return f1._divident * f2._devisor <= f2._divident * f1._devisor;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            var f3 = new Fraction(
                f1._divident * f2._devisor + f2._divident * f1._devisor,
                f1._devisor * f2._devisor);
            f3.Reduction();
            return f3;
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            var f3 = new Fraction(
                f1._divident * f2._devisor - f2._divident * f1._devisor,
                f1._devisor * f2._devisor);
            f3.Reduction();
            return f3;
        }
        
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            var f3 = new Fraction(
                f1._divident * f2._divident, f1._devisor * f2._devisor);
            f3.Reduction();
            return f3;
        }
        
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            var f3 = new Fraction(
                f1._divident * f2._devisor, f1._devisor * f2._divident);
            f3.Reduction();
            return f3;
        }
        
        public static Fraction operator %(Fraction f1, Fraction f2)
        {
            int common_devisor = f1._devisor * f2._devisor;
            int f1_divident = f1._divident * f2._devisor;
            int f2_divident = f2._divident * f1._devisor;
            
            var f3 = new Fraction( f1_divident % f2_divident, common_devisor);
            f3.Reduction();
            return f3;
        }

        public static Fraction operator ++(Fraction fr)
        {
            fr._divident += fr._devisor;
            fr.Reduction();
            return fr;
        }
        
        public static Fraction operator --(Fraction fr)
        {
            fr._divident -= fr._devisor;
            fr.Reduction();
            return fr;
        }

        public static explicit operator double(Fraction fr)
        {
            return (double) fr._divident / fr._devisor;
        }
        
        public static explicit operator float(Fraction fr)
        {
            return (float) fr._divident / fr._devisor;
        }
    }
}
