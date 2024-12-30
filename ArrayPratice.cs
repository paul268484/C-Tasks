using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ArrayPratice
    {

        public void arrayDisplay()
        {
            int[] number = { 4, 2, 9, 6, 10 };

            int length = number.Length;
            Console.WriteLine("array elements : ");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(number[i]);
            }

            Console.WriteLine("minimum number: " + number.Min());

            Console.WriteLine("minimum number: " + number.Max());

        }

        public void withOutMethod()
        {

            int[] num = { 3, 6, 8, 7, 9, 2, 1, 10 };

            int minValue = num[0];

            int maxValue = num[0];

            foreach (int i in num)
            {

                if (i < minValue)
                {
                    Console.WriteLine($"MaxValue => {minValue}");
                }

            }


        }
    }
}