namespace ChatONN.Core.ViewModels
{
    /// <summary>
    /// A view model which contains all the logic for the left side menu
    /// </summary>
    public class ChatNavigationSideMenuViewModel : BaseViewModel
    {
        /// <summary>
        /// Recent chats from direct messages
        /// </summary>
        public RecentChatListViewModel RecentDirectChats { get; set; }

        /// <summary>
        /// Recent chats from groups
        /// </summary>
        public RecentChatListViewModel RecentGroupChats { get; set; }

        /// <summary>
        /// Recent chats from groups
        /// </summary>
        public RecentChatListViewModel RecentPublicChats { get; set; }

        public ChatNavigationSideMenuViewModel()
        {

        }
    }
}