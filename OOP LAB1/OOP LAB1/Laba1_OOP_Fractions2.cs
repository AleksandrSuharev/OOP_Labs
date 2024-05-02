namespace Laba1_OOP_Fractions2
{
    public class Fractions
    {
        // Поля.
        private readonly int numerator;
        private readonly int denominator;

        // Свойства.
        private int Numerator
        {
            get { return numerator; }
        }
        private int Denominator
        {
            get { return denominator; }
        }

        // Конструкторы.
        public Fractions(int num, int den)
        {
            //DoubleMinus(num, den);
            //Reduce(num, den);
            if (den == 0)
            {
                Console.WriteLine("DivideByZeroException\nNow this denominator is one.");
                den = 1;
            }
            if ((num < 0 && den < 0) || den < 0)
            {
                num = -num;
                den = -den;
            }
            int N = GCD(Math.Abs(num), Math.Abs(den));
            num /= N;
            den /= N;
            numerator = num;
            denominator = den;
        }
        public Fractions()
        {
            numerator = 1;
            denominator = 1;
        }

        //Арифметические операции.
        public static Fractions operator +(Fractions fr_1, Fractions fr_2)
        {
            return new Fractions(fr_1.Numerator * fr_2.Denominator + fr_2.Numerator * fr_1.Denominator, fr_1.Denominator * fr_2.Denominator);
        }
        public static Fractions operator -(Fractions fr_1, Fractions fr_2)
        {
            return new Fractions(fr_1.Numerator * fr_2.Denominator - fr_2.Numerator * fr_1.Denominator, fr_1.Denominator * fr_2.Denominator);
        }
        public static Fractions operator *(Fractions fr_1, Fractions fr_2)
        {
            return new Fractions(fr_1.Numerator * fr_2.Numerator, fr_1.Denominator * fr_2.Denominator);
        }
        public static Fractions operator /(Fractions fr_1, Fractions fr_2)
        {
            return new Fractions(fr_1.Numerator * fr_2.Denominator, fr_1.Denominator * fr_2.Numerator);
        }
        public static Fractions operator +(int int_1, Fractions fr_2)
        {
            Fractions fr_1 = new Fractions(int_1, 1);
            return fr_1 + fr_2;
        }
        public static Fractions operator -(int int_1, Fractions fr_2)
        {
            Fractions fr_1 = new Fractions(int_1, 1);
            return fr_1 - fr_2;
        }
        public static Fractions operator *(int int_1, Fractions fr_2)
        {
            Fractions fr_1 = new Fractions(int_1, 1);
            return fr_1 * fr_2;
        }
        public static Fractions operator /(int int_1, Fractions fr_2)
        {
            Fractions fr_1 = new Fractions(int_1, 1);
            return fr_1 / fr_2;
        }
        public static Fractions operator +(Fractions fr_1, int int_2)
        {
            return int_2 + fr_1;
        }
        public static Fractions operator -(Fractions fr_1, int int_2)
        {
            return int_2 - fr_1;
        }
        public static Fractions operator *(Fractions fr_1, int int_2)
        {
            return int_2 * fr_1;
        }
        public static Fractions operator /(Fractions fr_1, int int_2)
        {
            return int_2 / fr_1;
        }
        public static Fractions operator -(Fractions fr_1)
        {
            return new Fractions(-fr_1.Numerator, fr_1.Denominator);
        }

        // Операции сравнения.
        public static bool operator ==(Fractions fr_1, Fractions fr_2)
        {
            if (fr_1.Numerator == fr_2.Numerator && fr_1.Denominator == fr_2.Denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Fractions fr_1, Fractions fr_2)
        {
            return !(fr_1 == fr_2);
        }
        public static bool operator >=(Fractions fr_1, Fractions fr_2)
        {
            int N = LCM(Math.Abs(fr_1.Denominator), Math.Abs(fr_2.Denominator));
            if (N == fr_1.Denominator)
            {
                if ((fr_1.Numerator) >= (fr_2.Numerator * N))
                {
                    return true;
                }
            }
            else if (N == fr_2.Denominator)
            {
                if ((fr_1.Numerator * N) >= (fr_2.Numerator))
                {
                    return true;
                }
            }
            else if ((fr_1.Numerator * N) >= (fr_2.Numerator * N))
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(Fractions fr_1, Fractions fr_2)
        {
            int N = LCM(Math.Abs(fr_1.Denominator), Math.Abs(fr_2.Denominator));
            if (N == fr_1.Denominator)
            {
                if ((fr_1.Numerator) <= (fr_2.Numerator * N))
                {
                    return true;
                }
            }
            else if (N == fr_2.Denominator)
            {
                if ((fr_1.Numerator * N) <= (fr_2.Numerator))
                {
                    return true;
                }
            }
            else if ((fr_1.Numerator * N) <= (fr_2.Numerator * N))
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Fractions fr_1, Fractions fr_2)
        {
            return !(fr_1 <= fr_2);
        }
        public static bool operator <(Fractions fr_1, Fractions fr_2)
        {
            return !(fr_1 >= fr_2);
        }
        public static bool operator ==(int int_1, Fractions fr_2)
        {
            return ToFractions(int_1) == fr_2;
        }
        public static bool operator !=(int int_1, Fractions fr_2)
        {
            return ToFractions(int_1) != fr_2;
        }
        public static bool operator >=(int int_1, Fractions fr_2)
        {
            return ToFractions(int_1) >= fr_2;
        }
        public static bool operator <=(int int_1, Fractions fr_2)
        {
            return ToFractions(int_1) <= fr_2;
        }
        public static bool operator >(int int_1, Fractions fr_2)
        {
            return ToFractions(int_1) > fr_2;
        }
        public static bool operator <(int int_1, Fractions fr_2)
        {
            return ToFractions(int_1) < fr_2;
        }
        public static bool operator ==(Fractions fr_1, int int_2)
        {
            return int_2 == fr_1;
        }
        public static bool operator !=(Fractions fr_1, int int_2)
        {
            return int_2 != fr_1;
        }
        public static bool operator >=(Fractions fr_1, int int_2)
        {
            return int_2 <= fr_1;
        }
        public static bool operator <=(Fractions fr_1, int int_2)
        {
            return int_2 >= fr_1;
        }
        public static bool operator >(Fractions fr_1, int int_2)
        {
            return int_2 < fr_1;
        }
        public static bool operator <(Fractions fr_1, int int_2)
        {
            return int_2 > fr_1;
        }

        // Иные функции.
        private static int GCD(int int_1, int int_2) //НОД
        {
            for (int i = (int_1 >= int_2 ? int_2 : int_1); i >/*=*/ 0; --i)
            {
                if (int_1 % i == 0 && int_2 % i == 0)
                {
                    return i;
                }
            }
            return 1;
        }
        private static int LCM(int int_1, int int_2) //НОК
        {
            return int_1 * int_2 / GCD(int_1, int_2);
        }
        public override string ToString()
        {
            string str = "";
            str += Numerator.ToString();
            if (Denominator != 1)
            {
                str += "/";
                str += Denominator.ToString();
            }
            return str;
        }
        public static Fractions ToFractions(int int_1)
        {
            return new Fractions(int_1, 1);
        }
    }
}