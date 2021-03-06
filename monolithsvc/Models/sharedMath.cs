using System;
using System.Net;
using Microsoft.Extensions.Configuration; 

namespace monolithsvc.Models
{

    public class sharedMath
    {

        public int addTwoNumbers (int a, int b)
        {
            return a+b;
        }

        public int multiplyTwoNumbers(int a, int b)
        {
            return a*b;
        }

        public int minusTwoNumbers(int a, int b)
        {
            return a-b;
        }

        public int mathresult {get;set;}
        public string dotnetver {get
            {
                return EnvironmentUtils.GetFrameworkDescription();
            }
        }

        public double powerTwoNumbers(int a, int b)
        {
            return Math.Pow(2,3);
        }
        public string hostname {get
            {
                return Environment.MachineName;
            }
        }

    }


}