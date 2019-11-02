using System;
using TreeListViewWithUnity.UI.UICore.DelegateCommands.Generic;

namespace TreeListViewWithUnity.UI.UICore.DelegateCommands
{
    public interface ICommandFactory
    {
        DelegateCommand CreateCommand(Action command);
        DelegateCommand<T> CreateCommand<T>(Action<T> command);
    }
}
