using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Person
{
    /// <summary>
    /// Jonathon Lyng
    /// Jan 19,2023
    /// </summary>
    internal class Persons
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string faveColor;
        private int age;
        private bool isWorking;

        public string FirstName
        { get
            { return this.firstName; }

        }
        public string LastName
        {
            get
            { return this.lastName; }
        }
        public string FaveColor
        { get
            { return this.faveColor; }
        }

        public int Age
        { get
            { return this.age; } 
        }

        public Persons(int personId, string firstName, string lastName, string faveColor, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.faveColor = faveColor;
            this.isWorking = isWorking;
        }


        //This displays the persons info in a sentence
        public void DisplayInfo()
        {
            int personId = this.personId;
            string firstName = this.firstName;
            string lastName = this.lastName;
            int age = this.age;
            string faveColor = this.faveColor;
            bool isWorking = this.isWorking;

            Console.WriteLine(personId + ": " + firstName + "'s " + lastName + " favorite colour is " + faveColor);
        }

        //This changes the faveorite color of the person
        public void ChangeFaveColor(string faveColor)
        {
            this.faveColor = faveColor;
        }

        //This adds ten years to the persons current age
        public string GetAgeInTenYears()
        {
            int addTenYears = age + 10;
            string newAge = firstName + " " + lastName + "'s age in 10 years will be " + addTenYears;
            return newAge;
        }

        //This shows the person selected's info into a list
        public override string ToString()
        {
            string dataList = string.Empty;

            dataList += "Person Id: " + this.personId + "\n";
            dataList += "First Name: " + this.firstName + "\n";
            dataList += "Last Name: " + this.lastName + "\n";
            dataList += "Favorite Color: " + this.faveColor + "\n";
            dataList += "Age: " + this.age + "\n";
            dataList += "Is Working: " + this.isWorking + "\n";

            return dataList;
        }

    }
}
