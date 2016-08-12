using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MvvmDemo.Annotations;
using MvvmDemo.utils;

namespace MvvmDemo
{
    public class MyViewModel : INotifyPropertyChanged
    {
        private MyModel _model;

        public string Name
        {
            get { return _model.Name; }
            set
            {
                _model.Name = value;
                OnPropertyChanged();
            }
        }
        public RelayCommand DoSomethingRelayCommand
        {
            get
            {
                return new RelayCommand(p => true, p => DoSomethingCommand());
            }
        }
        
        public MyViewModel()
        {
            _model = new MyModel();
        }

        private void DoSomethingCommand()
        {
            // YOU CAN'T ARGUE WITH THAT
            Name = "Maciek is great programmer";
        }

        #region INotifyPropertyChanged impl
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
