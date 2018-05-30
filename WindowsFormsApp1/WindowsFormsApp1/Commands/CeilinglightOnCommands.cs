using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Devices;

namespace WindowsFormsApp1.Commands
{
   public class CeilinglightOnCommands : iCommand
    {
        Ceilinglight ceilinglight = null;
        public CeilinglightOnCommands(Ceilinglight ceilinglight)
        {
            this.ceilinglight = ceilinglight;
        }
        public void Execute()
        {
            ceilinglight.On();
            ceilinglight.Dim();
            ceilinglight.Off();
        }


        public void Undo()
        {
            ceilinglight.Off();
            ceilinglight.Dim();
            ceilinglight.On();
        }
    
    }
}
