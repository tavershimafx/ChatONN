namespace ChatONN.Core.ViewModels
{
    public class SuggestionItemViewModel : BaseViewModel
    {
        /// <summary>
        /// The display name of the suggesting user
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// An absolute url path on the local system to the user's profile picture.
        /// </summary>
        public string UserProfileUrl { get; set; }

        /// <summary>
        /// An overview of the notification message.
        /// </summary>
        public string Message { get; set; }
    }
}