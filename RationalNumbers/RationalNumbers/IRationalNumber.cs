using System;
namespace RationalNumbers
{
    public interface IRationalNumber
    {
        IRationalNumber Add(IRationalNumber number);
        IRationalNumber Subtract(IRationalNumber number);
        IRationalNumber Multiply(IRationalNumber number);
        IRationalNumber Divide(IRationalNumber number);
        IRationalNumber Abs();
        IRationalNumber ExpRational(int power);
        double ExpReal(int baseNumber);
        // anything else you need to add?
    }
}
