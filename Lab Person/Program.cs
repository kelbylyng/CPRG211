using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //a
            Persons person1;
            person1 = new Persons(1, "Ian", "Brooks", "Red", 30, true);
            Persons person2;
            person2 = new Persons(2, "Gina", "James", "Green", 18, false);
            Persons person3;
            person3 = new Persons(3, "Mike", "Briscoe", "Blue", 45, true);
            Persons persons4;
            persons4 = new Persons(4, "Mary", "Beals", "Yellow", 28, true);
            Console.WriteLine("This is: " + person1);

            //b
            person2.DisplayInfo();

            //c
            Console.WriteLine(person3.ToString());

            //d 
            person1.ChangeFaveColor("White");
            person1.DisplayInfo();

            //e
            Console.WriteLine(persons4.GetAgeInTenYears());


        }
    }
}
