using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_
{
    class Program
    {
        static void Main(string[] args)
        {
            AzurePanel azurePanel = new AzurePanel();

            VirtualMachine vm = new VirtualMachine();

            TurnOnMachine turnOnCommand = new TurnOnMachine(vm);
            TurOffMachine turnOffCommand = new TurOffMachine(vm);

            azurePanel.AddCommand("turn on", turnOnCommand);
            azurePanel.AddCommand("turn off", turnOnCommand);

            azurePanel.Execute("turn on");
            azurePanel.Undo("turn on");
        }
    }
}
