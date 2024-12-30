using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class ArrayFunctions
    {

        public void showArrayFunction()
        {
            int[] num = new int[5]{ 10, 5, 6, 9, 27 };
            int[] newNumbers = new int[5];



            int index = Array.IndexOf(num,5);

            //Console.WriteLine(index);
            //Console.WriteLine(Array.BinarySearch(num, 6));
            num.CopyTo(newNumbers, 0);
            Array.Resize(ref newNumbers, 7);
            newNumbers[5] = 15;
            newNumbers[6] = 13;
           


            foreach(int numbers in newNumbers)
            {
                Console.WriteLine(numbers);
            }



        }
    }
}
