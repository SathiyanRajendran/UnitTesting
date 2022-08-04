using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTesting
{
    public class Calculator : ICalculator
    {
        public int add(int first, int second)
        {
           return first + second;
        }

        public float CalculateAmt(int qty, float price)
        {
            return qty * price;
        }

        public bool checkAge(int age)
        {
            if (age > 18)
                return true;
            else
                return false;
        }

        public bool checkAmt(int a, int b)
        {
            float f = CalculateAmt(a,b);
            if (f > 10)
                return true;
            else
                return false;
        }

        public string Login(string username, string password)
        {
            string msg;
            if((username=="user_11" && password=="sathiyan@123")||(username=="user_22" && password=="Sathya@000"))
            {
                msg = "Welcome " + username;
            }
            else
            {
                msg = "Invalid User Id/Password";
            }
            return msg;
         }

        public string message(string name)
        {
           return "Hello " + name;
        }

        public int TemperatureCheck(bool f)
        {
            if (f)
            {
                return 42;
            }
            else
                throw new InvalidOperationException("Temperature not Initialized");
        }

        public int Vote(bool v)
        {
            if (v)
                return 18;
            else
                throw new InvalidOperationException("Not Eligible");
        }
        
    }
}
