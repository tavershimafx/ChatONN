using ChatONN.Core.Data.SeedData;

namespace ChatONN.Core.ViewModels.Design
{
    public class ChatMessageListDesignModel : ChatMessageListViewModel
    {
        public static ChatMessageListDesignModel Instance { get; set; } = new();

        public ChatMessageListDesignModel()
        {
            this.Items = DesignTimeSeedData.ChatMessages();
        }
    }
}