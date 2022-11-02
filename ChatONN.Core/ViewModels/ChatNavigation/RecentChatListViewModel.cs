using System.Collections.ObjectModel;

namespace ChatONN.Core.ViewModels
{
    public class RecentChatListViewModel : BaseViewModel
    {
        public ObservableCollection<RecentChatItemViewModel> Items { get; set; }
    }
}