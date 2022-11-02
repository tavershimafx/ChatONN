using ChatONN.Core.Data.SeedData;

namespace ChatONN.Core.ViewModels.Design
{
    /// <summary>
    /// A design time model for the left side menu
    /// </summary>
    public class ChatNavigationSideMenuDesignModel : ChatNavigationSideMenuViewModel
    {
        public static ChatNavigationSideMenuDesignModel Instance { get; set; } = new();

        public ChatNavigationSideMenuDesignModel()
        {
            this.RecentDirectChats = new() { Items = DesignTimeSeedData.RecentChats() };
        }
    }
}