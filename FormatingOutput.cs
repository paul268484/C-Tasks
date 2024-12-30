using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
   public  class FormatingOutput
    {

        public string first_name, last_name, city;
        public string full_name;


        public void display()
        {
            Console.WriteLine("Enter first_name");
             first_name = Console.ReadLine();

            Console.WriteLine("enter last_name");
            last_name = Console.ReadLine();

            Console.WriteLine("enter city");
             city = Console.ReadLine();

            full_name = first_name + " " + last_name;
        }
    }
}
