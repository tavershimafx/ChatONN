using ChatONN.Core.Data.SeedData;

namespace ChatONN.Core.ViewModels.Design
{
    public class SuggestionPanelDesignModel : SuggestionSidePanel
    {
        public static SuggestionPanelDesignModel Instance { get; set; } = new();

        public SuggestionPanelDesignModel()
        {
            this.Suggestions = new() { Items = DesignTimeSeedData.Suggestions() };
        }
    }
}