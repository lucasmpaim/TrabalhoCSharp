using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using TrabalhoCSharp.Model.Repostiory;

namespace TrabalhoCSharp.Commands
{
    public abstract class BaseSaveCommand<T> where T: class, IEntity
    {

        public ICommand SaveCommand => new SaveCommandImpl<T>(this);

        public class SaveCommandImpl<T> : ICommand where T : class, IEntity
        {

            public BaseSaveCommand<T> _saveCommand;

            public SaveCommandImpl(BaseSaveCommand<T> _saveCommand)
            {
                this._saveCommand = _saveCommand;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                _saveCommand.Save();
            }

            public event EventHandler CanExecuteChanged;
        }

        public void Save()
        {
            try
            {
                var repository = new Repository<T>();
                repository.Add(Item);
                MessageBox.Show("Salvo com sucesso", "", MessageBoxButton.OK);
            }
            catch (DbEntityValidationException e)
            {
                var error = e.EntityValidationErrors.First().ValidationErrors.First().ErrorMessage;
                MessageBox.Show(error, "", MessageBoxButton.OK);
            }
        }

        public abstract T Item { get; }

    }
}
