using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP
{
    class TV : ElectricalDevice
    {
        public TV(bool isOn, string brand) : base(isOn, brand)
        {

        }

        public void WatchTV()
        {
            if (IsOn)
            {
                Console.WriteLine("Watching TV radio");
            }
            else
            {
                Console.WriteLine("Turn on TV first");
            }
        }
    }
}
