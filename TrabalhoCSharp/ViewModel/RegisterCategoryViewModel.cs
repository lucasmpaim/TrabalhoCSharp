using System;
using System.Linq;
using System.ComponentModel;
using System.Data.Entity.Validation;
using System.Windows;
using System.Windows.Input;
using TrabalhoCSharp.Commands;
using TrabalhoCSharp.Model.Pojo;
using TrabalhoCSharp.Model.Repostiory;


namespace TrabalhoCSharp.ViewModel
{
    class RegisterCategoryViewModel : BaseSaveCommand<Category>, INotifyPropertyChanged
    {

        private readonly IRepository<Category> _categoryRepository
            = new Repository<Category>();

        private Category _category;

        public Category Category
        {
            get => _category;
            set
            {
                _category = value;
               NotifyOfPropertyChange("Category");
            }
        }


        public RegisterCategoryViewModel()
        {
            Category = new Category();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyOfPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public override Category Item => Category;
    }

}
