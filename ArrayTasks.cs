using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
     class ArrayTasks
    {
        public void showArrayExists()
        {
            int[] arr = { 6, 8, 5, 4, 7, 2 };

            Console.WriteLine("Enter a element to search: ");

            int input = Convert.ToInt32(Console.ReadLine());

            int index = Array.IndexOf(arr,input);

            if(index == -1)
            {
                Console.WriteLine("Element is not present");
            }
            else
            {
                Console.WriteLine("element is  present");
            }
        }

    }
}
