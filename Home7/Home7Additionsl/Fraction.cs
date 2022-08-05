namespace Home7Additionsl
{
    internal class Fraction
    {
        private int _denominator = 1;

        public Fraction() { }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public int Numerator { get; set; } = 0;

        public int Denominator
        {
            get { return _denominator; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("So strong denominator!");
                }

                _denominator = value;
            }
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }

        public static Fraction ReduceFraction(in Fraction otherFraction)
        {
            if (otherFraction == null)
            {
                throw new NullReferenceException("Argument is null!");
            }

            int gcd = GCD(otherFraction.Numerator, otherFraction.Denominator);

            if (gcd == 1)
            {
                throw new ArithmeticException("This fraction cannot be reduced!");
            }
            else
            {
                otherFraction.Numerator /= gcd;
                otherFraction.Denominator /= gcd;

                return otherFraction;
            }
        }

        public static bool TryReduceFraction(in Fraction otherFraction, out Fraction resultFraction)
        {
            if (otherFraction == null)
            {
                resultFraction = null;

                return false;
            }

            int gcd = GCD(otherFraction.Numerator, otherFraction.Denominator);

            if (gcd == 1)
            {
                resultFraction = null;

                return false;
            }
            else
            {
                resultFraction = new Fraction(otherFraction.Numerator / gcd, otherFraction.Denominator / gcd);
                
                return true;
            }
        }

        public static double Parse(in Fraction otherFraction)
        {
            if (otherFraction == null)
            {
                throw new NullReferenceException("Argument is null!");
            }

            return (double)otherFraction.Numerator/otherFraction.Denominator;
        }

        public static bool TryParse(in Fraction otherFraction, out double result)
        {
            if (otherFraction == null)
            {
                result = 0;

                return false;
            }

            result = (double)otherFraction.Numerator/otherFraction.Denominator;

            return true;
        }

        public static Fraction operator +(in Fraction fraction1, in Fraction fraction2)
        {
            if (fraction1 == null || fraction2 == null)
            {
                throw new NullReferenceException("Arguments is null!");
            }

            Fraction result = new Fraction();

            if (fraction1.Denominator == fraction2.Denominator)
            {
                result.Numerator = fraction1.Numerator + fraction2.Numerator;
                result.Denominator = fraction1.Denominator;
            }
            else
            {
                result.Numerator = fraction1.Numerator * fraction2.Denominator 
                    + fraction2.Numerator * fraction1.Denominator;

                result.Denominator = fraction1.Denominator * fraction2.Denominator;
            }

            if (TryReduceFraction(result,out Fraction reduceFraction))
            {
                return reduceFraction;
            }

            return result;
        }

        public static Fraction operator -(in Fraction fraction1, in Fraction fraction2)
        {
            if (fraction1 == null || fraction2 == null)
            {
                throw new NullReferenceException("Arguments is null!");
            }

            Fraction result = new Fraction();

            if (fraction1.Denominator == fraction2.Denominator)
            {
                result.Numerator = fraction1.Numerator - fraction2.Numerator;
                result.Denominator = fraction1.Denominator;
            }
            else
            {
                result.Numerator = fraction1.Numerator * fraction2.Denominator
                    - fraction2.Numerator * fraction1.Denominator;

                result.Denominator = fraction1.Denominator * fraction2.Denominator;
            }

            if (TryReduceFraction(result, out Fraction reduceFraction))
            {
                return reduceFraction;
            }

            return result;
        }

        public static Fraction operator /(in Fraction fraction1, in Fraction fraction2)
        {
            if (fraction1 == null || fraction2 == null)
            {
                throw new NullReferenceException("Arguments is null!");
            }

            Fraction result = new Fraction();

            result.Numerator = fraction1.Numerator * fraction2.Denominator;
            result.Denominator = fraction1.Denominator * fraction2.Numerator;

            if (TryReduceFraction(result, out Fraction reduceFraction))
            {
                return reduceFraction;
            }

            return result;
        }

        public static Fraction operator *(in Fraction fraction1, in Fraction fraction2)
        {
            if (fraction1 == null || fraction2 == null)
            {
                throw new NullReferenceException("Arguments is null!");
            }

            Fraction result = new Fraction();

            result.Numerator = fraction1.Numerator * fraction2.Numerator;
            result.Denominator = fraction1.Denominator * fraction2.Denominator;

            if (TryReduceFraction(result, out Fraction reduceFraction))
            {
                return reduceFraction;
            }

            return result;
        }

        public static explicit operator double(in Fraction otherFraction)
        {
            return Parse(otherFraction);
        }

        private static int GCD(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else
            {
                int min = Math.Min(a, b);
                int max = Math.Max(a, b);
                return GCD(max % min, min);
            }
        }
    }

}
