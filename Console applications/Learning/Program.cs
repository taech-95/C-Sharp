using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Learning
{ 
    class Program
    {

        public static int Add(int param1, int param2) => param1 + param2;
        public static int Multiply(int param1, int param2) => param1 * param2;
        public static double Devide(double param1, double param2) => param1 / param2;
        public static void WriteSomething()
        {
            Console.WriteLine("I'm called from the method;");
            Console.Read();
        }
        public static void GreetFriend(string name)
        {
             Console.WriteLine($"Hi {name}, my friend");
        }
        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //int age = 26;
            /**//*string name = "Mykola";*//*
            Console.WriteLine("Hello my name is " + name + ", I am " + age + "years old");
            Console.WriteLine("Hello my name is {0}, I am {1} years old", name, age);
            Console.WriteLine($"Hello my name is {name}, I am {age} years old");
            Console.WriteLine(@"Lorem ipsum dolor sit amet consectetur adipisicing elit.
            Dolor consequuntur tempore numquam placeat debitis, totam quibusdam perferendis dolores, 
            reiciendis quam saepe dolorem aliquam magni. Nisi culpa nostrum laborum alias pariatur!");
            Console.WriteLine("Hello world");*/
            /* Console.WriteLine("Enter your name: ");
             string yourName = Console.ReadLine();
             Console.WriteLine(yourName.ToUpper());
             Console.WriteLine(yourName.ToLower());
             Console.WriteLine(yourName.Trim());
             Console.WriteLine(yourName.Substring(1, 5));
             string input = Console.ReadLine();
             char searchInInput = Console.ReadLine()[0];
             int searchIndex = input.IndexOf(searchInInput);
             Console.WriteLine($"Index of character {searchIndex}  in string is {searchIndex}");
             Console.WriteLine("Enter your name: ");
             string name = Console.ReadLine();
             Console.WriteLine("Enter your surname: ");
             string surname = Console.ReadLine();
             string fullName = String.Concat(name, " ", surname);
             Console.WriteLine(fullName);
             Console.ReadLine();*/
            string friendsName = "Sasha";
            WriteSomething();
            WriteSomethingSpecific("Mykola");
            Console.WriteLine(Add(5, 19));
            Console.WriteLine(Devide(7, 4));
            GreetFriend(friendsName);

        }
    }
}
