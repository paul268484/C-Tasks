using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
     class ArrayTask2
    {
        public void fruitTask()
        {

            String[] fruits = { "Apple", "Banana", "Orange", "Grapes", "Mango" };

            Console.WriteLine("Enter fruit for search : ");

            string input = Console.ReadLine();

            int index = Array.IndexOf(fruits, input);

           




        }
    }
}
