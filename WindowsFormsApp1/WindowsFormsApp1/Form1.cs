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
        bool flag=false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;

            foreach (var buf in label)
            {
                if (buf.BackColor != Color.MediumTurquoise)
                {
                    buf.BackColor = Color.MediumTurquoise;
                }
            }
            label3.BackColor = Color.MediumSeaGreen;

            if (label3.BackColor == Color.MediumSeaGreen & flag == false)
            {

                RemoteControl remoteControl = new RemoteControl();
                Sprinkler Sprinkler = new Sprinkler(richTextBox1);
                SprinklerOnCommand sprinklerOnCommand = new SprinklerOnCommand(Sprinkler);
                SprinklerOffCommand sprinklerOffCommand = new SprinklerOffCommand(Sprinkler);
               
                remoteControl.SetCommand(2, sprinklerOnCommand, sprinklerOffCommand);
                remoteControl.OnButtonWasPushed(2);
                flag = true;

            }

            else
            {
                richTextBox1.Text = null;
                richTextBox1.Text = "Sprinkler is On\nPress key Off Sprinkler";

            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;

            foreach (var buf in label)
            {
                if (buf.BackColor != Color.MediumTurquoise)
                {
                    buf.BackColor = Color.MediumTurquoise;
                }
            }
            label10.BackColor = Color.MediumSeaGreen;

            if (label10.BackColor == Color.MediumSeaGreen & flag == true)
            {

                RemoteControl remoteControl = new RemoteControl();
                Sprinkler Sprinkler = new Sprinkler(richTextBox1);
                SprinklerOnCommand sprinklerOnCommand = new SprinklerOnCommand(Sprinkler);
                SprinklerOffCommand sprinklerOffCommand = new SprinklerOffCommand(Sprinkler);

                remoteControl.SetCommand(2, sprinklerOnCommand, sprinklerOffCommand);
                remoteControl.OffButtonWasPushed(2);
                flag = false;

            }

            else
            {
                richTextBox1.Text = null;
                richTextBox1.Text = "Sprinkler is Off\nPress key On Sprinkler";

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;

            foreach (var buf in label)
            {
                if (buf.BackColor != Color.MediumTurquoise)
                {
                    buf.BackColor = Color.MediumTurquoise;
                }
            }
            label4.BackColor = Color.MediumSeaGreen;

            if (label4.BackColor == Color.MediumSeaGreen & flag == true )
            {

                RemoteControl remoteControl = new RemoteControl();
                Ceilinglight ceilinglight = new Ceilinglight(richTextBox1);
                CeilinglightOnCommands ceilinglightOnCommand = new CeilinglightOnCommands(ceilinglight);
                CeilinglightOffCommands ceilinglightOffCommand = new CeilinglightOffCommands(ceilinglight);

                remoteControl.SetCommand(3, ceilinglightOnCommand, ceilinglightOffCommand);
                remoteControl.OnButtonWasPushed(3);
                flag = false;

            }

            else
            {
                richTextBox1.Text = null;
                richTextBox1.Text = "Ceiling light is On\nPress key Off Ceiling light";

            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;

            foreach (var buf in label)
            {
                if (buf.BackColor != Color.MediumTurquoise)
                {
                    buf.BackColor = Color.MediumTurquoise;
                }
            }
            label11.BackColor = Color.MediumSeaGreen;

            if (label11.BackColor == Color.MediumSeaGreen & flag == true)
            {

                RemoteControl remoteControl = new RemoteControl();
                Ceilinglight ceilinglight = new Ceilinglight(richTextBox1);
                CeilinglightOnCommands ceilinglightOnCommand = new CeilinglightOnCommands(ceilinglight);
                CeilinglightOffCommands ceilinglightOffCommand = new CeilinglightOffCommands(ceilinglight);

                remoteControl.SetCommand(3, ceilinglightOnCommand, ceilinglightOffCommand);
                remoteControl.OffButtonWasPushed(3);
                flag = false;

            }

            else
            {
                richTextBox1.Text = null;
                richTextBox1.Text = "Ceiling light is Off\nPress key On Ceiling light";

            }
        }
    }
    
}
