using System;
using System.Collections.Generic;
/* 4.	Random List
 * Date: 03 NOV 2020
 * Create a RandomList class that has all the functionality of List<string>.
Add additional function that returns and removes a random element from the list.
•	Public method: RandomString(): string
*/

namespace ReusingClasses
{
    class RandomList
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Random List");
            List<String> names = new List<string>();
            Console.WriteLine("Please enter the no. of names");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the names");
            for (int i = 0; i < number; i++)
            {
                names.Add(Console.ReadLine());
            }
            //To select random
            RandomList RM = new RandomList();
            names.Remove(RM.getRandomElement(names));
            Console.WriteLine("After removal the available names are:");
            foreach (String n in names)
            Console.WriteLine(n);
     }
        public String getRandomElement(List<String> list)
        {
            Random rand = new Random();
            int index = rand.Next(list.Count);
            Console.WriteLine("Randomly selected name is:");
            Console.WriteLine(list[index]);
            return (list[index]);
        }

    }
}
