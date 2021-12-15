using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    

    class Person_Class
    {
        public int Height { get; set; }
        public string Education { get; set; }

        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        public Person_Class()
        {
            Console.WriteLine("Object created");
        }

        public Person_Class(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        public Person_Class(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }


        public void IntroduceMyself()
        {
            Console.WriteLine($"My name is {firstName} {lastName}. I'm {age} years old, and I have {eyeColor} eyes");
        }

    }
}
