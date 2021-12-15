using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Box
    {

        private int length = 3;
        private int height;
        private int width;
        private int volume;

        //public int Volume { get; set; }

        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }


        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                height = value;
            }
        }

        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        
        public int Volume
        {
            get
            {
                return this.length * this.width * this.height;
            }
        }

        public Box()
        {

        }
        public Box(int length, int height, int width)
        {
            this.length = length;
            Width = width;
            this.height = height;
        } 
        public void DisplayInfo()
        {
            Console.WriteLine($"The length is " +
                $"{length} and height is {height} and the width is " +
                $"{Width} and volume is equal " +
                $"{volume = length * height * Width}");
        }
    }
}
