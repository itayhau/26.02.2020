using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_
{
    public class VirtualMachine
    {
        public bool IsOn { get; private set; }
        public bool HasAntiVirusInstalled { get; private set; }
        public bool IsAntiVirusRunning { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
        }
        public void TurnOff()
        {
            IsOn = false;
        }
        public void RunAntiVirus()
        {
            IsAntiVirusRunning = true;
            // ...........
            Console.WriteLine("Running anti virus... ");

            // .. finished
            IsAntiVirusRunning = false;
        }
        public void StopAntiVirus()
        {
            // .... 
            Console.WriteLine("Stopping anti virus... ");
            IsAntiVirusRunning = false;
        }

    }
}
