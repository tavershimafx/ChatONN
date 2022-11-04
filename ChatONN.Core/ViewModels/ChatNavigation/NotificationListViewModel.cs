using System.Collections.ObjectModel;

namespace ChatONN.Core.ViewModels
{
    public class NotificationListViewModel : BaseViewModel
    {
        public ObservableCollection<NotificationItemViewModel> Items { get; set; }
    }
}