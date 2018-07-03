using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using TrabalhoCSharp.Annotations;
using TrabalhoCSharp.Commands;
using TrabalhoCSharp.Model.Pojo;
using TrabalhoCSharp.Model.Repostiory;

namespace TrabalhoCSharp.ViewModel
{
    public class RegisterNewGameViewModel : BaseSaveCommand<Game>,  INotifyPropertyChanged
    {

        private Repository<Category> _categoryRepository { get; set; }

        private Game _game { set; get; }
        private ObservableCollection<Category> _allCategories;


        public Game Game
        {
            get => _game;
            set
            {
                _game = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Category> AllCategories
        {
            get => _allCategories;
            set
            {
                _allCategories = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public RegisterNewGameViewModel()
        {
            _categoryRepository = new Repository<Category>();
            Game = new Game();

            AllCategories = new ObservableCollection<Category>(
                    _categoryRepository.FetchAll()
                );

        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override Game Item => Game;
    }
}
