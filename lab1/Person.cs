using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Person
    {
        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColor;
        private int age;
        private bool isWorking;

        public Person(int personId, string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            this.personId = personId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColor = favoriteColor;
            this.age = age;
            this.isWorking = isWorking;
        } 
        public void DisplayPersonInfo()
        {
            Console.WriteLine(personId +":"+ firstName + " " + lastName + "’s favorite colour is " + favoriteColor);
        }


        public override string ToString()
        {
            return ($"personId:{personId}\n firstName: {firstName}\n lastName:{lastName} \nfavoriteColo:{favoriteColor}\nage: {age}\nIsWorking:{isWorking}");
        }

        public void ChangeFavoriteColour()
        {
            this.favoriteColor = "white";
        }

        public void GetAgeInTenYears()
        {
            this.age = age + 10;
            Console.WriteLine(firstName + " " + lastName + "’s Age in 10 years is:" +  38);
        }
    }
}
