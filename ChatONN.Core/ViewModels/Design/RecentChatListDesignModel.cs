using ChatONN.Core.Data.SeedData;
using System.Collections.ObjectModel;

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