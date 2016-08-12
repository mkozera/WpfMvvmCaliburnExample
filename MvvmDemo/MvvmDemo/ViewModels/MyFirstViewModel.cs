using Caliburn.Micro;

namespace MvvmDemo.ViewModels
{
    public class MyFirstViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;

        public MyFirstViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void GoNext()
        {
            _eventAggregator.PublishOnBackgroundThread("GoNextScreenPlz");
        }
    }
}
