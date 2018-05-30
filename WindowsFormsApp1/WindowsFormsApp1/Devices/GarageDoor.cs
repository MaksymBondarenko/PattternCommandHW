using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1.Devices
{
   
    public class GarageDoor:Form1
    {
        
        public GarageDoor(RichTextBox richTextBox1)
        {
            this.richTextBox1 = richTextBox1;
            
        }
        public void On()
        {
            richTextBox1.Text +="\nGarage Door is Open";
            
        }

        public void Off()
        {
            richTextBox1.Text += "\nGarage Door is Closed";
        }

        public void Stop()
        {
            richTextBox1.Text += "Door is Stop";
        }

        public void LightOn()
        {
            richTextBox1.Text += "\nLight is On";
        }

        public void LightOff()
        {
            richTextBox1.Text += "\nLight is Off";
        }

    }
}
