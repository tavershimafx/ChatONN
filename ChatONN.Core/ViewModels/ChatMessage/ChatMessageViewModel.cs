using ChatONN.Core.Utilities.Enums;

namespace ChatONN.Core.ViewModels
{
    /// <summary>
    /// A view model for a message in the conversation.
    /// </summary>
    public class ChatMessageViewModel : BaseViewModel
    {
        /// <summary>
        /// The message content
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The time the last message was sent
        /// </summary>
        public DateTimeOffset MessageTime { get; set; }

        public string MessageTimeString
        {
            get
            {
                return MessageTime.UtcDateTime.ToShortTimeString();
            }
        }

        public bool IsSentByMe { get; set; }

        public ElementHorizontalAlignment HorizontalAlignment 
        {
            get { return IsSentByMe ? ElementHorizontalAlignment.Right : ElementHorizontalAlignment.Left; }
        }

        /// <summary>
        /// The next item to it
        /// </summary>
        public ChatMessageViewModel Next { get; set; }

        /// <summary>
        /// The previous item to it
        /// </summary>
        public ChatMessageViewModel Previous { get; set; }
    }

}