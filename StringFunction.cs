using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
     class StringFunction
    {
        string fullName = "anmol m chaware";
        string greetmsg = "Good Afternoon";
        string city1 = "ongole";
        string city2 = "Ongole";


        public void showStringMethods()
        {
            Console.WriteLine("Actual string: " + fullName);
            Console.WriteLine(fullName.ToLower()); // to convert to lower case
            Console.WriteLine(fullName.ToUpper()); // to convert to lower case
            Console.WriteLine(fullName[0]); // access elements by using index
            Console.WriteLine(fullName.Substring(1,4)); 
            Console.WriteLine(city1.Equals(city2,StringComparison.OrdinalIgnoreCase));// to compare two strings
            Console.WriteLine(fullName.Remove(1,4));// removes elements by using index
            Console.WriteLine(fullName.StartsWith("Anmol"));
            Console.WriteLine(fullName.EndsWith("Anmol"));
            Console.WriteLine("replace anmol with Anmol=> " + fullName.Replace("anmol", "Anmol", StringComparison.OrdinalIgnoreCase));
        }



    }
}
