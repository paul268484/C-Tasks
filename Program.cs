using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Assignment
{

    public class Program
    {
      static void Main(string[] args)
       {
            ListTask lt = new ListTask();

            lt.displayMenu();
            lt.addFruit();
            lt.updateFruit();
            lt.deleteFruit();


            //ListMethods lm = new ListMethods();

            //lm.showListMethods();




            //ArrayTasks at = new ArrayTasks();

            //at.showArrayExists();


            //ArrayFunctions af = new ArrayFunctions();
            //af.showArrayFunction();

            //StringWordCount swc = new StringWordCount();

            //swc.countWords();





            //StringReplace sr = new StringReplace();

            //sr.stringReplace();



            //DateTimeMethod dateTimeMethod = new DateTimeMethod();

            //dateTimeMethod.showDateTimeMethod();


            //Array arr = new Array();

            //arr.arrayDisplay();


            //MathMethods mm = new MathMethods();

            //mm.userInputMethods();




            //StringFunction sf = new StringFunction();

            //sf.showStringMethods();


            //FormatingOutput fo = new FormatingOutput();

            //fo.display();

            //Console.WriteLine(fo.full_name + " is coming from " + fo.city);
        }
    }
}