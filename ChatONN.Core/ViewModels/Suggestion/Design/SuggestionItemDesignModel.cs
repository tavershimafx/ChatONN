namespace ChatONN.Core.ViewModels.Design
{
    public class SuggestionItemDesignModel : SuggestionItemViewModel
    {
        public static SuggestionItemDesignModel Instance { get; set; } = new();
        public SuggestionItemDesignModel()
        {
            Message = "Are we meeting today? Lets talk about the progress of our work.";
            UserProfileUrl = @"\Resources\Images\sm\avatar1.jpg";
        }
    }
}