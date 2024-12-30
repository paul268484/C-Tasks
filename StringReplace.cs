using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class StringReplace
    {
        public void stringReplace()
        {
            string[] fruits = { "banana", "apple", "grapes", "mango", };

            Console.WriteLine("Actual array:");


            for (int i = 0; i < fruits.Length; i++)
            {
                Console.WriteLine( fruits[i]);

                if (fruits[i] == "grapes")
                {
                    Console.WriteLine("grapes is present ");
                 
                    fruits[i] = "orange";
                    break;
                }
              
            }

                Console.WriteLine("updated array:");
                foreach(string fruit in fruits)
                {
                    Console.WriteLine( fruit);
                }


            }

         

        


        }
    }

