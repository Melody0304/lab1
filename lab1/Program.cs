using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Person peron1 = new Person(1, "Ian", "Brooks", "Red", 30, true);
            Person peron2 = new Person(2, "Gina", "James", "Green", 18, false);
            Person peron3 = new Person(3, "Mike", " Briscoe", " Blue", 45, true);
            Person peron4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);


            peron1.DisplayPersonInfo();
            Console.WriteLine(peron1.ToString());
            peron1.ChangeFavoriteColour(); ;
            Console.WriteLine(peron2.ToString());
            peron2.GetAgeInTenYears();
            Console.WriteLine(peron3.ToString());
            Console.WriteLine(peron4.ToString());
            
            peron1.DisplayPersonInfo();
            


        }
    }
}
