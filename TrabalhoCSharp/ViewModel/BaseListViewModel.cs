using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using TrabalhoCSharp.Annotations;
using TrabalhoCSharp.Commands;
using TrabalhoCSharp.Model.Repostiory;

namespace TrabalhoCSharp.ViewModel
{
    public abstract class BaseListViewModel<T> : BaseDeleteCommand<T>, INotifyPropertyChanged where T : class, IEntity
    {

        public int _selectedIndex { get; set; }

        public int SelectedIndex
        {
            get => _selectedIndex;
            set
            {
                _selectedIndex = value;
                OnPropertyChanged();
            }

        }

        public override T Item
        {
            get
            {
                if (SelectedIndex >= Items.Count)
                    return null;
                return Items[SelectedIndex];
            }
        }

        public override void Delete()
        {
            base.Delete();
            Items = new ObservableCollection<T>(_repository.FetchAll());
        }

        private IRepository<T> _repository;

        private ObservableCollection<T> _items;

        public ObservableCollection<T> Items
        {

            set
            {
                _items = value;
                OnPropertyChanged();
            }
            get => _items;
        }


        public BaseListViewModel()
        {
            _repository = new Repository<T>();
            Items = new ObservableCollection<T>(_repository.FetchAll());
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
