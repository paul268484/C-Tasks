using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class ListTask
    {
       
        List<string> fruits = new List<string>() { "Apple", "Banana", "Grapes", "Mango", "Orange" };

     
        public void listTaskMethods()
        {
            printFunction();
        }

        public void printFunction() {
            for (int i = 0; i < fruits.Count; i++)
            {
                Console.WriteLine(fruits[i]);
            }
        }

        public void addFruit()
        {
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("Enter the fruit to enter: ");
            string input = Console.ReadLine();

          
                if (fruits.Contains(input))
                {
                    Console.WriteLine("fruit is already exist");
                        addFruit();
                }
                else
                {
                    fruits.Add(input);
                    Console.WriteLine("added successfully");
                }

              
            }
        

        public void updateFruit(){

            Console.WriteLine("Enter the existing fruit want to update:");
            string update = Console.ReadLine();
            Console.WriteLine("enter the new fruit");
            string newValue = Console.ReadLine();

            if(fruits.Contains(newValue))
            {
                Console.WriteLine("Fruit you that entered already exists , Try with another one:");
                updateFruit();
            }
            else
            {
                int index =fruits.IndexOf(update);
                fruits.Remove(update);
                fruits.Insert(index, newValue);

            }



        }

        public void deleteFruit()
        {
            Console.WriteLine("Enter the fruitname to delete:");
            string input = Console.ReadLine();
            
            if (fruits.Contains(input))
            {
                fruits.Remove(input);
                Console.WriteLine("fruit removed successfully");
            }
            else
            {
                Console.WriteLine("There is no fruit in the list that you entered");
                deleteFruit();
            }

        }



        public void displayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("----------------------------");
            Console.WriteLine("1).Display fruit :");
            Console.WriteLine("2).Add fruit :");
            Console.WriteLine("3).Update fruit :");
            Console.WriteLine("4).Delete fruit :");
            Console.WriteLine("5).Exit: ");
            Console.WriteLine("Enter your choice: ");
            int inp = Convert.ToInt32(Console.ReadLine());
            display(inp);
        }
            public void display(int input)
            {
              switch (input)
              {
                case 1:

                    listTaskMethods();
                    displayMenu();
                    break;

                case 2:
                    addFruit();
                    displayMenu();
                    break;

                case 3:
                    updateFruit();
                    displayMenu();
                    break;
                case 4:
                    deleteFruit();
                    displayMenu();
                    break;
                case 5:
                    break;
                default:
                    break;

            }

               }

        

        
    }
}
