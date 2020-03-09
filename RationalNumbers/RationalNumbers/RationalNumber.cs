using System;


namespace RationalNumbers
{
    public struct RationalNumber : IRationalNumber
    {
        public int Numerator { get; private set; }
        public int Denominator { get; private set; }

        public RationalNumber(int numerator)
        {
           this.Numerator = numerator;
           this.Denominator = 1; 
        }

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException("Cannot devide by zero");
          if (denominator<0)
            this.Numerator = (0-numerator);
          else
                this.Numerator =  numerator ;
            this.Denominator = Math.Abs(denominator);
        }

        public static IRationalNumber operator +(RationalNumber r1, RationalNumber r2) => r1.Add(r2);

        public static IRationalNumber operator -(RationalNumber r1, RationalNumber r2) => r1.Subtract(r2);

        public static IRationalNumber operator *(RationalNumber r1, RationalNumber r2) => r1.Multiply(r2);

        public static IRationalNumber operator /(RationalNumber r1, RationalNumber r2) => r1.Divide(r2);

        public IRationalNumber Abs()
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        public IRationalNumber Reduce()//used to be private
        {

            int divisor = GCD(Numerator, Denominator);
            Console.WriteLine(divisor);
            return new  RationalNumber(Numerator / divisor, Denominator/divisor);
        }
        private int GCD(int a, int b)
        {
            if (b == 0)
                return a;
            return GCD(b, a % b);

        }
        public IRationalNumber ExpRational(int power)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        public double ExpReal(int baseNumber)
        {
            throw new NotImplementedException("You need to implement this function.");
        }

        public IRationalNumber Add(IRationalNumber number)
        {
            RationalNumber r2 = (RationalNumber) number ;
            throw new NotImplementedException("You need to implement this function.");
            //  var doub =  (double)((this.Numerator * r2.Denominator + r2.Numerator * this.Denominator) / (this.Denominator * r2.Denominator));
            //  return (IRationalNumber)doub;
        }

        public IRationalNumber Subtract(IRationalNumber number)
        {
            throw new NotImplementedException();
        }

        public IRationalNumber Multiply(IRationalNumber number)
        {
            throw new NotImplementedException();
        }

        public IRationalNumber Divide(IRationalNumber number)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denominator}";
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj); // replace this with the correct expression or remove
        }

        public override int GetHashCode()
        {
            return base.GetHashCode(); // replace this with the correct expression or remove
        }

        // plus any other methods you deem necessary to meet the specification
    }

    public static class IntNumberExtension
    {
        // exponentiate real number to the rational number power
        public static double ExpReal(this int intNumber, RationalNumber r)
        {
            return 0; // replace with correct call
        }
    }
}
