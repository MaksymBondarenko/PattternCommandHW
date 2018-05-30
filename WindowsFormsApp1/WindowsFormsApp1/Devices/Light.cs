using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Devices
{
    
    public class Light:Form1
    {
        public Light(RichTextBox richTextBox1)
        {
            this.richTextBox1 = richTextBox1;

        }
        public void On()
        {
            richTextBox1.Text="\nLight is On";
        }

        public void Off()
        {
            richTextBox1.Text = "\nLight is Off";
        }
    }
}
