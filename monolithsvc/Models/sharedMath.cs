using System;
using System.Net;
using Microsoft.Extensions.Configuration; 

namespace monolithsvc.Models
{

    public class SharedMath
    {

        public static int AddTwoNumbers (int a, int b)
        {
            return a+b;
        }

        public static int MultiplyTwoNumbers(int a, int b)
        {
            return a*b;
        }

        public static int MinusTwoNumbers(int a, int b)
        {
            return a-b;
        }

        public int Mathresult {get;set;}
        public string Dotnetver{get;} = EnvironmentUtils.GetFrameworkDescription();
        
        public static double PowerTwoNumbers(int a, int b)
        {
            return Math.Pow(2,3);
        }

        public static string Hostname() 
        {
                return Environment.MachineName;
        }

    }


}