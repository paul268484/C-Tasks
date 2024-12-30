using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class ListMethods
    {

        public void showListMethods()
        {
            List<int> num = new List<int>() { 2, 40, 10, 15, 100, 74 };
            List<int> newNumbers = new List<int>() { 6, 20, 9 };

         

            num.Add(12);
            num.Insert(2, 55);

            num.Remove(55);
            num.InsertRange(3, newNumbers);
            num.Sort();
            num.Reverse();
            num.RemoveAt(4);


            for (int i = 0; i <num.Count; i++)
            {

                Console.WriteLine(num[i]);
            }

        }
    }
}
