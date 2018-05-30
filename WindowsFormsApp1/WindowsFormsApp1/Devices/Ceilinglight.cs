using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Devices
{
   public class Ceilinglight: Form1
    {
        public Ceilinglight(RichTextBox richTextBox1)
        {
            this.richTextBox1 = richTextBox1;

        }
        public void On()
        {
            richTextBox1.Text = "\nCeiling light is On";
        }
        public void Dim()
        {
            richTextBox1.Text = "\nCeiling light is dim";
        }
        public void Off()
        {
            richTextBox1.Text = "\nCeiling light is Off";
        }
    }
}
