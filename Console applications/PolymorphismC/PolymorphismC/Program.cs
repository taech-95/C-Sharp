using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismC
{
    class Program
    {

        static void Main(string[] args)
        {

            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            foreach (var car in cars)
            {
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "green", "A3");
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIDInfo(1234, "Denis Panjuta");
            audiA3.SetCarIDInfo(1235, "Frank White");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails();

            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            M3 myM3 = new M3(260, "red", "M3 Super Turbo");
            myM3.Repair();

            //Shape shape = new Shape();
            Shape[] shapes = { new Sphere(4), new Cube(3) };
            foreach (Shape shape  in shapes)
            {

                Console.WriteLine(shape.Volume());
            }
            Console.ReadKey();
        }
    }
}
