using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP
{
    class Dog : Animal
    {
        public bool IsHappy { get; set; }
        public Dog (int age, string name) : base( age, name)
        {
            IsHappy = true;
        }

        public override void Eat()
        {
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Bark bark bark");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
            else
            {
                Console.WriteLine($"Make {Name} happy");
            }

        }


    }
}
