using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QACalculator
{
    public class Calculator
    {

        //public int Add(String n1)
        //{
        //    // check string empty
        //    if (n1 == "") return 0;

        //    // split by comma
        //    var seperatedNumbers = n1.Split(',');

        //    // if only 1 number, return number
        //    if(seperatedNumbers.Length < 1)
        //    {
        //        return int.Parse(n1);
        //    }

        //    // parse all seperated numbers into numbers and add to a number array
        //    var parsedNumberArray = new List<int>();
        //    foreach (var seperatednumber in seperatedNumbers)
        //    {
        //        parsedNumberArray.Add(int.Parse(seperatednumber));
        //    }

        //    // return them added together
        //    return parsedNumberArray[0] + parsedNumberArray[1];
        //}

        public int Add(String n1)
        {
            if(n1 == "") return 0;

            return 1;
        }

        public int Divide(String n1)
        {
            int result = -9999;
            char separator = ',';
            // if doesn't contain a comma call this
            if (!n1.Contains(","))
                separator = Utils.ValidSeperator(n1);    // slows down test
            String[] numbers = n1.Split(separator);
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) / Utils.ToNumber(numbers[1]);
            return result;
        }

        public int Multiply(String n1)
        {
            int result = -9999;
            String[] numbers = n1.Split(',');
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {  // check number is valid
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) * Utils.ToNumber(numbers[1]);
            return result;
        }

        public int Subtract(String n1)
        {
            int result = -9999;

            String[] numbers = n1.Split(',');
            foreach (String number in numbers)
            {
                if (!Utils.IsNumeric(number))
                {  // check number is valid
                    return result;
                }
            }
            result = Utils.ToNumber(numbers[0]) - Utils.ToNumber(numbers[1]);
            return result;
        }
    }
}
