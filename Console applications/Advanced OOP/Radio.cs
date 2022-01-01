using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_OOP
{
     class Radio : ElectricalDevice
    {
 
        public Radio( bool isOn, string brand): base (isOn, brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        public void ListenRadio()
        {
            if (IsOn)
            {
                Console.WriteLine("Listening radio");
            }
            else
            {
                Console.WriteLine("Radio is turn off");
            }
        }
    }
}
