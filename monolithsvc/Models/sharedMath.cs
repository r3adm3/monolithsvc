using System;
using System.Net;
using Microsoft.Extensions.Configuration; 

namespace monolithsvc.Models
{

    public class SharedMath
    {

        public int AddTwoNumbers (int a, int b)
        {
            return a+b;
        }

        public int MultiplyTwoNumbers(int a, int b)
        {
            return a*b;
        }

        public int MinusTwoNumbers(int a, int b)
        {
            return a-b;
        }

        public int Mathresult {get;set;}
        public string Dotnetver {get
            {
                return EnvironmentUtils.GetFrameworkDescription();
            }
        }

        public double PowerTwoNumbers(int a, int b)
        {
            return Math.Pow(2,3);
        }
        public string Hostname {get
            {
                return Environment.MachineName;
            }
        }

    }


}