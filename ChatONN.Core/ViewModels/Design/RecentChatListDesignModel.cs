using ChatONN.Core.Data.SeedData;

namespace ChatONN.Core.ViewModels.Design
{
    public class RecentChatListDesignModel : RecentChatListViewModel
    {
        public static RecentChatListDesignModel Instance { get; set; } = new();

        public RecentChatListDesignModel()
        {
            this.Items = DesignTimeSeedData.RecentChats();
        }
    }
}