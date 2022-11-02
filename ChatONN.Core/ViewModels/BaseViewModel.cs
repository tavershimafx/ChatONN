using PropertyChanged;
using System.ComponentModel;

namespace ChatONN.Core
{
    [AddINotifyPropertyChangedInterface]
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged = delegate { };

        public void NotifyPropertyChaged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}