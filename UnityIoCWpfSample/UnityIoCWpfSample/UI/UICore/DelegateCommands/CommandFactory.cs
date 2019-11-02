using System;
using TreeListViewWithUnity.UI.UICore.DelegateCommands.Generic;

namespace TreeListViewWithUnity.UI.UICore.DelegateCommands
{
    public class CommandFactory : ICommandFactory
    {
        public DelegateCommand CreateCommand(Action command)
        {
            return new DelegateCommand(command);
        }

        public DelegateCommand<T> CreateCommand<T>(Action<T> command)
        {
            return new DelegateCommand<T>(command);
        }
    }
}
