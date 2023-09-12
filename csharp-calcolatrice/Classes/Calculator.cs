using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice.Classes
{
    public static class Calculator
    {

        //STATIC METHODS

        // SUM OF TWO T(type binded to numbers interface)
        public static T sumOfTwoT<T>(T a, T b) where T : INumber<T>
        {
            return a + b;
        }

        // SUBSTRACTION OF TWO T(type binded to numbers interface)
        public static T substractionOfTwoT<T>(T a, T b) where T : INumber<T>
        {
            return a - b;
        }

        // MULTIPLICATION OF TWO T(type binded to numbers interface)
        public static T multiplyTwoT<T>(T a, T b) where T : INumber<T>
        {
            return a * b;
        }

        // Absolute Value Of an INT
        public static int AbsoluteValueOf(int a)
        {
            return Math.Abs(a);
        }  

        // Absolute Value Of a DOUBLE
        public static double AbsoluteValueOf(double a)
        {
            return Math.Abs(a);
        }

        // Return the Min value of two ints
        public static int MinOf(int a, int b) 
        {
            return Math.Min(a, b);
        }

        // Return the Min value of two doubles
        public static double MinOf(double a, double b) 
        {
            return Math.Min(a, b);
        } 

        // Return the Max value of two ints
        public static int MaxOf(int a, int b) 
        {
            return Math.Max(a, b);
        }

        // Return the Max value of two doubles
        public static double MaxOf(double a, double b) 
        {
            return Math.Max(a, b);
        }

        // Takes two inputs (base, power to elevate to) and return the base elevated to power

        // option 1
        public static int PowerOf(int baseNum, int power)
        {
            int positivePow = Calculator.AbsoluteValueOf(power);
            int positiveBaseNum = Calculator.AbsoluteValueOf(baseNum);
            return (int)Math.Pow(positiveBaseNum, positivePow);
        }  

        // option 2
        public static int PowerOfAlt(int baseNum, int power)
        {
            int start = 1;
            int positivePow = Calculator.AbsoluteValueOf(power);
            int positiveBaseNum = Calculator.AbsoluteValueOf(baseNum);

            for (int i = 0; i < positivePow; i++)
            {
                start *= positiveBaseNum;
            }
            return start;
        }
    }

    // il principio è il polimorfismo
}
