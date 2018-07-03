using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using TrabalhoCSharp.Model.Repostiory;

namespace TrabalhoCSharp.Commands
{
    public abstract class BaseDeleteCommand<T> where T : class, IEntity
    {
        public ICommand DeleteCommand => new DeleteCommandImpl<T>(this);

        public class DeleteCommandImpl<T> : ICommand where T : class, IEntity
        {

            public BaseDeleteCommand<T> _command;

            public DeleteCommandImpl(BaseDeleteCommand<T> _command)
            {
                this._command = _command;
            }

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public void Execute(object parameter)
            {
                _command.Delete();
            }

            public event EventHandler CanExecuteChanged;
        }

        public virtual void Delete()
        {
            try
            {
                var repository = new Repository<T>();
                repository.Remove(Item);
                MessageBox.Show("Deletado com sucesso", "", MessageBoxButton.OK);
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
