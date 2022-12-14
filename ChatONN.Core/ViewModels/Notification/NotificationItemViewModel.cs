namespace ChatONN.Core.ViewModels
{
    public class NotificationItemViewModel : BaseViewModel
    {
        /// <summary>
        /// An absolute url path on the local system to the user's profile picture.
        /// </summary>
        public string UserProfileUrl { get; set; }

        /// <summary>
        /// An overview of the notification message.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// The time the notification was pushed.
        /// </summary>
        public DateTimeOffset NotificationTime { get; set; }

        /// <summary>
        /// A relative time string of the <see cref="NotificationTime"/>
        /// </summary>
        public string RelativeTimeString 
        {
            get
            {
                return NotificationTime.UtcDateTime.ToShortTimeString();
            }
        }
    }
}