using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_
{
    public class RunAntiVirus : ICommand
    {
        private VirtualMachine _vm;

        public RunAntiVirus(VirtualMachine vm)
        {
            this._vm = vm;
        }
        public void Execute()
        {
            _vm.RunAntiVirus();
        }

        public void Undo()
        {
            _vm.StopAntiVirus();
        }
    }
}
