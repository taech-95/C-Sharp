using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio(false, "Samsung");
            radio.SwitchOn();
            radio.ListenRadio();

            Dog dog = new Dog( 12, "Geralt");
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.Eat();
            dog.Play();
            dog.MakeSound();

        }
    }
}
