using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
   
    public enum SIGN
    {
        PLUS,
        MINUS,
        MULTIPLY,
        DIVIDE
    }

    public class Calculator
    {

        private Double calculate(SIGN sign, Double arg1, Double arg2)
        {
            switch (sign)
            {
                case SIGN.MULTIPLY:
                    return arg1 * arg2; 
                case SIGN.MINUS:
                    return arg1 - arg2; 
                case SIGN.PLUS:
                    return arg1 + arg2; 
                default:
                    break;
            }
            return 0;
        }
    }
}
