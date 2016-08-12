using Caliburn.Micro;

namespace MvvmDemo.ViewModels
{
    public class MySecondViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;

        public MySecondViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

        public void GoPrev()
        {
            _eventAggregator.PublishOnBackgroundThread("GoPrevScreenPlox");
        }
    }
}