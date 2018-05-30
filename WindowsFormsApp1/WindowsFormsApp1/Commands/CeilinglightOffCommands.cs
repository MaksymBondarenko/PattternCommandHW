using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Devices;

namespace WindowsFormsApp1.Commands
{
    class CeilinglightOffCommands : iCommand
    {
        Ceilinglight ceilinglight = null;
        public CeilinglightOffCommands(Ceilinglight ceilinglight)
        {
            this.ceilinglight = ceilinglight;
        }

        public void Execute()
        {
            ceilinglight.Off();
            ceilinglight.Dim();
            ceilinglight.On();

        }


        public void Undo()
        {
            ceilinglight.On();
            ceilinglight.Dim();
            ceilinglight.Off();
        }
    }
}
