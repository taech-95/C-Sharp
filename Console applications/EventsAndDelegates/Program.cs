using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegates
{
  
    class Program
    {

        public delegate bool FilterDelegate(Person p);

        static bool Filter(string s)
        {
            return s.Contains("e");
        }

        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Mykola", "Stefan", "Oksana" };
            foreach (string name  in names)
            {
                Console.WriteLine(name);
            }
            names.RemoveAll(Filter);
            Console.WriteLine("-----------------------------");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Person p1 = new Person() { Name = "Mykola", Age = 27 };
            Person p2 = new Person() { Name = "Stefan", Age = 28 };
            Person p3 = new Person() { Name = "Olena", Age = 25 };
            Person p4 = new Person() { Name = "Oksana", Age = 51 };

            List<Person> persons = new List<Person>() { p1, p2, p3, p4 };
            DisplayPeople("Adults", persons, IsAdult);
            FilterDelegate filter = delegate (Person p)
            {
                return p.Age >= 65;
            };
            string searchKey = "a";
            DisplayPeople("Age greater then 20 and contain " + searchKey, persons, (p) =>  p.Age>=25 && p.Name.Contains(searchKey));
        }

        static void DisplayPeople (string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);
            foreach (Person person in people)
            {
                if (filter(person))
                {
                    Console.WriteLine($"{person.Name}, {person.Age}");
                }
            }
        }

        static bool IsMinor(Person p)
        {
            return p.Age < 18;

        }
        static bool IsAdult(Person p)
        {
            return p.Age > 18;

        }
    }
}
