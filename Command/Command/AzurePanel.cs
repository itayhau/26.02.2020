using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_
{
    public class AzurePanel
    {

        private Dictionary<string, ICommand> _commands;
        public AzurePanel()
        {

        }

        public void AddCommand(string key, ICommand command)
        {
            _commands.Add(key, command);
        }

        public void Execute(string key)
        {
            // assert
            _commands[key].Execute();
        }

        public void Undo(string key)
        {
            // assert
            _commands[key].Undo();
        }
    }
}
