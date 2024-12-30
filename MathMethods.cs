using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class MathMethods
    {

        int num1;
        int num2;
        
        public void userInputMethods()
        {


            Console.WriteLine("enter first number: ");
             num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("floor of num1 and num2=> " + Math.Floor(10.6));
            Console.WriteLine("Max number between num1 and num2 => " + Math.Max(num1, num2));
            Console.WriteLine("Min number between num1 and num2=> " + Math.Min(num1, num2));
            Console.WriteLine("floor of num1 and num2=> " + Math.Floor(10.6));


        }

        //public void methodDisplay()
        //{
        //    Console.WriteLine("Max number between 5 and 9 => " + Math.Max(5, 9));// it returns the max value
        //    Console.WriteLine("Min number between 5 and 9 => " + Math.Min(5, 9));// it returns the min value
        //    Console.WriteLine(Math.Floor(6.5));
        //    Console.WriteLine(Math.Round(6.5));
        //    Console.WriteLine("Sqaure root of 8 => " + Math.Sqrt(8));
        //    Console.WriteLine("Abs of -10 =>" + Math.Abs(-10));
        //   Console.WriteLine("power of 2 and 6 => " + Math.Pow(2,6));
        //    Console.WriteLine("ceiling => " + Math.Ceiling(10.5));
        //}



    }
}
