using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP
{
    class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public bool IsHungry { get; set; }

        public Animal(int age, string name)
        {
            Age = age;
            Name = name;
            IsHungry = true;
        }

        public virtual void MakeSound()
        {

        }
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing");
        }

    }
}
