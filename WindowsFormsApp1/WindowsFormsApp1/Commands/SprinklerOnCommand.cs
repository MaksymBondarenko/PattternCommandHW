using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Devices;

namespace WindowsFormsApp1.Commands
{
   public class SprinklerOnCommand : iCommand
    {
        Sprinkler Sprinkler = null;
        public SprinklerOnCommand(Sprinkler Sprinkler)
        {
            this.Sprinkler = Sprinkler;
        }
        public void Execute()
        {
            Sprinkler.On();
            Sprinkler.Off();
        }

        public void Undo()
        {
            Sprinkler.Off();
            Sprinkler.Off();
        }
    }
    
}
