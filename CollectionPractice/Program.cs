using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> myGroupOne = new List<Person>();
            myGroupOne.Add(new Person() { Id = 123, Navn = "Mikkel" });
            myGroupOne.Add(new Person() { Id = 234, Navn = "Janus" });
            myGroupOne.Add(new Person() { Id = 345, Navn = "Birgitte" });

            foreach (var item in myGroupOne)
            {
                Console.WriteLine("Person in my group has ID {0} and name {1} ", item.Id, item.Navn);
            }

            Dictionary<int, Person> myGroupTwo = new Dictionary<int, Person>();
            myGroupTwo.Add(1, new Person() { Id = 123, Navn = "Mikkel" });
            myGroupTwo.Add(2, new Person() { Id = 234, Navn = "Janus" });
            myGroupTwo.Add(3, new Person() { Id = 456, Navn = "Jens" });

            foreach (var person1 in myGroupOne)
            {
                foreach (var person2 in myGroupTwo)
                {
                    if (person1.Id == person2.Value.Id)
                        Console.WriteLine("Person {0} is found in the dictionary", person1.Navn);
                }
            }

        }
    }
}
