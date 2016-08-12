using Caliburn.Micro;
using MvvmDemo.utils;

namespace MvvmDemo.ViewModels
{
    public class MyViewModel : PropertyChangedBase
    {
        private readonly MyModel _model;

        public string Name
        {
            get
            {
                return _model.Name;
            }

            set
            {
                _model.Name = value;
                NotifyOfPropertyChange(() => Name);
            }
        }
        
        public MyViewModel()
        {
            _model = new MyModel
            {
                Name = "contructor name"
            };
        }

        public void DoSomethingCommand()
        {
            // YOU CAN'T ARGUE WITH THAT
            Name = "Maciek is great programmer";
        }
    }
}
