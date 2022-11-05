namespace ChatONN.Core.ViewModels.Design
{
    public class RecentChatItemDesignModel : RecentChatItemViewModel
    {
        public static RecentChatItemDesignModel Instance { get; set; } = new ();
        public RecentChatItemDesignModel()
        {
            Username = "Ankit Mishra";
            LastMessage = "Are we meeting today? Lets talk about the progress of our work.";
            LastMessageTime = DateTimeOffset.Now;
            UnreadMessageCount = 2;
            ProfilePictureUrl = "";
        }
    }
}