using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Project_Work_WPF.Commands
{
	class RelayCommand<T> : ICommand
	{

		private readonly Predicate<T> _canExecute;
		private readonly Action<T> _execute;

		public RelayCommand(Action<T> execute) : this(execute, null)
		{
			_execute = execute;
		}

		public RelayCommand(Action<T> execute, Predicate<T> canExecute = null)
		{ 
			if (execute == null)
			{
				throw new ArgumentNullException("execute");
			}
			_execute = execute;
			_canExecute = canExecute;
		}

		public bool CanExecute(object parameter)
		{
			return _canExecute == null || _canExecute((T)parameter);
		}

		public void Execute(object parameter)
		{
			_execute((T)parameter);
		}

		public event EventHandler CanExecuteChanged
		{
			add { CommandManager.RequerySuggested += value; }
			remove { CommandManager.RequerySuggested -= value; }
		}
	}

	public class RelayCommand : ICommand
	{
		private readonly Predicate<object> _canExecute;
		private readonly Action<object> _execute;

		public RelayCommand(Action<object> execute) : this(execute, null)
		{
			_execute = execute;
		}

		public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
		{
			if (execute == null)
			{
				throw new ArgumentNullException("execute");
			}
			_execute = execute;
			_canExecute = canExecute;
		}

		public bool CanExecute(object parameter)
		{
			return _canExecute == null || _canExecute(parameter);
		}

		public void Execute(object parameter)
		{
			_execute(parameter);
		} 

		public event EventHandler CanExecuteChanged
		{
			add
			{
				CommandManager.RequerySuggested += value;
				CanExecuteChangedInternal += value;
			}
			remove
			{
				CommandManager.RequerySuggested -= value;
				CanExecuteChangedInternal -= value;
			}
		}

		private event EventHandler CanExecuteChangedInternal;

		public void RaiseCanExecuteChanged()
		{
			CanExecuteChangedInternal.Raise(this);
		}
	}

	public abstract class AsyncCommandBase : ICommand
	{
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public async void Execute(object parameter)
		{
			await ExecuteAsync(parameter);
		}

		protected abstract Task ExecuteAsync(object parameter);
	}

}
