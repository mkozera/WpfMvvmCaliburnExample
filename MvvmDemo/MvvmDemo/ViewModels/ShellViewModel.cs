using System.Collections.Generic;
using Caliburn.Micro;

namespace MvvmDemo.ViewModels
{
    public class ShellViewModel : Conductor<IScreen>.Collection.OneActive , IHandle<string>
    {
        private IList<IScreen> _screens = new List<IScreen>();
        public ShellViewModel(IEventAggregator eventAggregator, MyFirstViewModel myFirstViewModel, MySecondViewModel mySecondViewModel)
        {
            _screens.Add(myFirstViewModel);
            _screens.Add(mySecondViewModel);

            ActivateItem(_screens[0]);
            eventAggregator.Subscribe(this);
        }
        public void Handle(string message)
        {
            if (message == "GoNextScreenPlz")
            {
                ActivateItem(_screens[1]);
            }
            else if (message == "GoPrevScreenPlox")
            {
                ActivateItem(_screens[0]);
            }
        }
    }
}
