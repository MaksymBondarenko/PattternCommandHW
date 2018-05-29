using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Devices
{
    public class GarageDoor: Form1
    {
        public void On()
        {
           
            Console.WriteLine("Garage Door is Open");
        }

        public void Off()
        {
            Console.WriteLine("Garage Door is Closed");
        }

        public void Stop()
        {
            Console.WriteLine("Door is Stop");
        }

        public void LightOn()
        {
            Console.WriteLine("Light is On");
        }

        public void LightOff()
        {
            Console.WriteLine("Light is Off");
        }

    }
}
