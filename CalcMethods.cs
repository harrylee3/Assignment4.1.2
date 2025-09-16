using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._1._2
{
    internal class CalcMethods : ICalculator
    {
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public double Divide(int number1, int number2)
        {
            if (number2 == 0)
            {
                MessageBox.Show("Denominator cannot be zero.");
            }
            return (double) number1 / number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }
        
    }
}
