using System;
using System.Collections.Generic;
using System.Text;

namespace CalculateDataLibrary
{
    public class CalculateData
    {
        public double AddTwoNumbers(double theFirstNumber, double theSecondNumber)
        {
            double output = 0;

            output = theFirstNumber + theSecondNumber;

            return output;
        }

        public double SubtractTwoNumbers(double theFirstNumber, double theSecondNumber)
        {
            double output = 0;

            output = theFirstNumber - theSecondNumber;

            return output;
        }

        public double MultiplyTwoNumbers(double theFirstNumber, double theSecondNumber)
        {
            double output = 0;

            output = theFirstNumber * theSecondNumber;

            return output;
        }

        public double DivideTwoNumbers(double theFirstNumber, double theSecondNumber)
        {
            double output = 0;

            if (theSecondNumber != 0)
            {
                output = theFirstNumber / theSecondNumber;
            }

            

            return output;
        }

        

    }
}
