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
             if (numerator == 0) { 
                this.Numerator = 0;
                 this.Denominator = 1;//even if denom was negative, results would have been zero anyway
            }
            else { 
                if (denominator<0)
                   this.Numerator = (0-numerator);
                else
                 this.Numerator =  numerator ;
                
                 this.Denominator = Math.Abs(denominator);
                }
        }

        public static IRationalNumber operator +(RationalNumber r1, RationalNumber r2) => r1.Add(r2);

        public static IRationalNumber operator -(RationalNumber r1, RationalNumber r2) => r1.Subtract(r2);

        public static IRationalNumber operator *(RationalNumber r1, RationalNumber r2) => r1.Multiply(r2);

        public static IRationalNumber operator /(RationalNumber r1, RationalNumber r2) => r1.Divide(r2);

        public IRationalNumber Abs()
        {
            return new RationalNumber(Math.Abs(this.Numerator), Math.Abs(this.Denominator));
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
         // var bla = Math.Pow(this.Numerator, power);
            // RationalNumber r2 = (RationalNumber)number;
              return new RationalNumber((int)Math.Pow(this.Numerator, power), (int)Math.Pow(this.Denominator, power));
            //(a ^ n) / (b ^ n)
            //  throw new NotImplementedException("You need to implement this function.");
        }

        public double ExpReal(int baseNumber)
        {
         return  baseNumber.ExpReal(this);
        }

        public IRationalNumber Add(IRationalNumber number)
        {
            RationalNumber r2 = (RationalNumber) number ;
            return   new RationalNumber((this.Numerator * r2.Denominator + r2.Numerator * this.Denominator) ,(this.Denominator * r2.Denominator)).Reduce();
         }

        public IRationalNumber Subtract(IRationalNumber number)
        {
            RationalNumber r2 = (RationalNumber)number;
            return new RationalNumber((this.Numerator * r2.Denominator - r2.Numerator * this.Denominator), (this.Denominator * r2.Denominator)).Reduce();
        }

        public IRationalNumber Multiply(IRationalNumber number)
        {
            RationalNumber r2 = (RationalNumber)number;
            return new RationalNumber((this.Numerator*r2.Numerator), (this.Denominator*r2.Denominator)).Reduce();
        }

        public IRationalNumber Divide(IRationalNumber number)
        {
            RationalNumber r2 = (RationalNumber)number;
            try { 
            return new RationalNumber((this.Numerator * r2.Denominator), (this.Denominator * r2.Numerator)).Reduce(); //https://www.helpwithfractions.com/dividing-fractions
             }

            catch (DivideByZeroException ex)
            {
               throw new DivideByZeroException("Error trying to multiply two fractions: {0}", ex);
            }
        
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
        {//Math.Pow(x, 1.0 / n);
            return Math.Pow(Math.Pow(intNumber, r.Numerator), 1.0/r.Denominator); // replace with correct call
          //  Exponentiation of a real number x to a rational number r = a / b is x ^ (a / b) = root(x ^ a, b), where root(p, q) is the qth root of p.
        }
    }
}
