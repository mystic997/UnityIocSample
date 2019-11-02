using System;
using System.Diagnostics;

namespace TreeListViewWithUnity.UI.UICore.DelegateCommands
{
    public class DelegateCommand : IDelegateCommand
    {
        #region Private Properties

        /// <summary>
        /// Gets / sets the action to be executed.
        /// </summary>
        private Action ExecuteAction { get; set; }

        #endregion Private Properties

        #region Public Events

        /// <summary>
        /// Occurs when changes occur that affect whether 
        /// the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged;

        #endregion Public Events

        #region Public Constructors

        /// <summary>
        /// Initializes a new instance of <see cref="DelegateCommand"/>
        /// with the action to be executed.
        /// </summary>
        /// <param name="executeAction">
        /// Action to be executed.
        /// </param>
        public DelegateCommand(Action executeAction)
        {
            ExecuteAction = executeAction;
        }

        #endregion Public Constructors

        #region Public Methods

        /// <summary>
        /// Determines whether the command can execute in its current state.
        /// </summary>
        /// <param name="parameter">Data used by the command.</param>
        /// <returns>
        /// <c>true</c> if this command can be executed; 
        /// otherwise, <c>false</c>.
        /// </returns>
        public bool CanExecute(object parameter)
        {
            return true;
        }

        /// <summary>
        /// Invokes the method to be called.
        /// </summary>
        /// <param name="parameter">Data used by the command.</param>
        public void Execute(object parameter)
        {
            try
            {
                ExecuteAction();
            }
            catch (Exception)
            {
                Debug.WriteLine("Error occured. Logging...");
            }
        }

        #endregion Public Methods
    }
}
