using System.Collections.ObjectModel;

namespace ChatONN.Core.ViewModels
{
    public class ChatMessageListViewModel : BaseViewModel
    {
        public ObservableLinkedList Items { get; set; }
    }
}