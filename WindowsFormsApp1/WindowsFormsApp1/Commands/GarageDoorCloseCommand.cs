﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Devices;

namespace WindowsFormsApp1.Commands
{
    public class GarageDoorCloseCommand: iCommand
    {
        GarageDoor garageDoor = null;
        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }
        public void Execute()
        {
            garageDoor.Stop();
            garageDoor.Off();
            garageDoor.LightOff();
        }

        public void Undo()
        {
            garageDoor.Stop();
            garageDoor.On();
            garageDoor.LightOn();
        }
    }
}
