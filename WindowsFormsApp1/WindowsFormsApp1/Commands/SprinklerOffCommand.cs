using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Devices;

namespace WindowsFormsApp1.Commands
{
    public class SprinklerOffCommand : iCommand
    {
        Sprinkler Sprinkler = null;
        public SprinklerOffCommand(Sprinkler Sprinkler)
        {
            this.Sprinkler = Sprinkler;
        }
        public void Execute()
        {
            Sprinkler.Off();
            Sprinkler.On();
        }

        public void Undo()
        {
            Sprinkler.On();
            Sprinkler.Off();
        }
    }
}
