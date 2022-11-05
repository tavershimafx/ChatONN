using ChatONN.Core.Data.SeedData;

namespace ChatONN.Core.ViewModels.Design
{
    public class SuggestionListDesignModel : SuggestionListViewModel
    {
        public static SuggestionListDesignModel Instance { get; set; } = new();

        public SuggestionListDesignModel()
        {
            this.Items = DesignTimeSeedData.Suggestions();
        }
    }
}