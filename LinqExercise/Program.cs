using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(10);
            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }

            Console.WriteLine("Now the names are sorted.");
            Console.WriteLine();
            var sorted = from p in people orderby p.Name select p;
            foreach (var person in sorted)
            {
                Console.WriteLine(person.Name);
            }
            
            Console.WriteLine("Now the gender and names are sorted.");
            Console.WriteLine();
            sorted = from p in people orderby p.Gender, p.Name select p;
            foreach (var person in sorted)
            {
                Console.WriteLine(person.Name);
            }

            var filtered = from p in people where p.Height > 170 select p;
            foreach (var item in filtered)
            {

            }
        }
    }
}
