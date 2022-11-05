using System.Collections.ObjectModel;

namespace ChatONN.Core.ViewModels
{
    public class SuggestionListViewModel : BaseViewModel
    {
        public ObservableCollection<SuggestionItemViewModel> Items { get; set; }
    }
}