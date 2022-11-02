namespace ChatONN.Core.ViewModels
{
    /// <summary>
    /// A view model for a recent chat with a user shown in list.
    /// </summary>
    public class RecentChatItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The username of the chatting user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// A local url path the user's profile picture
        /// </summary>
        public string ProfilePictureUrl { get; set; }

        /// <summary>
        /// The last message of the conversation
        /// </summary>
        public string LastMessage { get; set; }

        /// <summary>
        /// The time the last message was sent
        /// </summary>
        public DateTimeOffset LastMessageTime { get; set; }

        public string LastMessageTimeString
        {
            get
            {
                return LastMessageTime.UtcDateTime.ToShortTimeString();
            }
        }

        /// <summary>
        /// Number of unread messages
        /// </summary>
        public int UnreadMessageCount { get; set; }
    }
}