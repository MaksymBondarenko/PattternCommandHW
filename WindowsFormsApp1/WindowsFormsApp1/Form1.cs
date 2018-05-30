using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Clients;
using WindowsFormsApp1.Commands;
using WindowsFormsApp1.Devices;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static bool flag = false;
       public static int i = 0;
        List<Label> label = new List<Label>();
        public Form1()
        {
            InitializeComponent();

            label = new List<Label>
            {
                label1,
                label2,
                label3,
                label4,
                label5,
                label6,
                label7,
                label8,
                label9,
                label10,
                label11,
                label12,
                label13,
                label14
            };
            

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            if (flag == false)
            {
                foreach (var buf in label)
                {
                    if (buf.BackColor != Color.MediumTurquoise)
                    {
                        buf.BackColor = Color.MediumTurquoise;
                    }
                }
                label1.BackColor = Color.MediumSeaGreen;
                RemoteControl remoteControl = new RemoteControl();
                //GarageDoor
                GarageDoor garageDoor = new GarageDoor(richTextBox1);
                GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
                GarageDoorCloseCommand garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);
                remoteControl.SetCommand(0, garageDoorOpenCommand, garageDoorCloseCommand);
                remoteControl.OnButtonWasPushed(0);
                flag = true;
            }
            else
            {               
                richTextBox1.Text = null;
                richTextBox1.Text = "Door is open\nPress key close door";
                
            }
            
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            
                richTextBox1.Text = null;
               
                foreach (var buf in label)
                {
                    if (buf.BackColor != Color.MediumTurquoise)
                    {
                        buf.BackColor = Color.MediumTurquoise;
                    }
                    
                }                
            
            if (flag == true)
            {
                
                label8.BackColor = Color.MediumSeaGreen;
                RemoteControl remoteControl = new RemoteControl();
                //GarageDoor
                GarageDoor garageDoor = new GarageDoor(richTextBox1);
                GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);
                GarageDoorCloseCommand garageDoorCloseCommand = new GarageDoorCloseCommand(garageDoor);
                remoteControl.SetCommand(0, garageDoorOpenCommand, garageDoorCloseCommand);
                remoteControl.OffButtonWasPushed(0);
                flag = false;
            }
            else
            {
                richTextBox1.Text = null;
                richTextBox1.Text = "Door is Close\nPress key open door";               
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
            
           foreach (var buf in label)
                {
                    if (buf.BackColor != Color.MediumTurquoise)
                    {
                        buf.BackColor = Color.MediumTurquoise;
                    }
                }
             label2.BackColor = Color.MediumSeaGreen;
           
            if(label2.BackColor==Color.MediumSeaGreen & flag == false)
            {
                RemoteControl remoteControl = new RemoteControl();
                //GarageDoor
                GarageDoor garageDoor = new GarageDoor(richTextBox1);

                Light light = new Light(richTextBox1);
                LightOnCommand lightOnCommand = new LightOnCommand(light);
                LightOffCommand lightOffCommand = new LightOffCommand(light);
                remoteControl.SetCommand(1, lightOnCommand, lightOffCommand);
                remoteControl.OnButtonWasPushed(1);
                flag = true;
               
            }

            else
            {
                richTextBox1.Text = null;
                richTextBox1.Text = "Light is On\nPress key Off light";
                
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;

            foreach (var buf in label)
            {
                if (buf.BackColor != Color.MediumTurquoise)
                {
                    buf.BackColor = Color.MediumTurquoise;
                }
            }
            label9.BackColor = Color.MediumSeaGreen;

            if (label9.BackColor == Color.MediumSeaGreen & flag == true)
            {
                RemoteControl remoteControl = new RemoteControl();
                //GarageDoor
                GarageDoor garageDoor = new GarageDoor(richTextBox1);

                Light light = new Light(richTextBox1);
                LightOnCommand lightOnCommand = new LightOnCommand(light);
                LightOffCommand lightOffCommand = new LightOffCommand(light);
                remoteControl.SetCommand(1, lightOnCommand, lightOffCommand);
                remoteControl.OffButtonWasPushed(1);
                flag = false;

            }

            else
            {
                richTextBox1.Text = null;
                richTextBox1.Text = "Light is Off\nPress key On light";

            }
        }
    }
    
}
