namespace ChatONN.Core.Utilities.Enums
{
    public enum MessageType
    {
        /// <summary>
        /// A message that contains texts and or links
        /// </summary>
        Text = 0,

        /// <summary>
        /// A message that is an image file
        /// </summary>
        Image,

        /// <summary>
        /// A message of mime type audio
        /// </summary>
        Audio,

        /// <summary>
        /// A message of mimetype video
        /// </summary>
        Video,

        /// <summary>
        /// A contact card
        /// </summary>
        Contact,

        /// <summary>
        /// A document or any other binary file shared
        /// </summary>
        Document
    }
}
