namespace ChatONN.Core.ViewModels.Design
{
    public class ChatMessageDesignModel : ChatMessageViewModel
    {
        public static ChatMessageDesignModel Instance { get; set; } = new ();

        public static LinkedListNode<ChatMessageViewModel> Item { get; set; } = new(new ChatMessageViewModel
        {
            Message = "Are we meeting today? Lets talk about the progress of our work.",
            MessageTime = DateTimeOffset.Now,
            IsSentByMe = false,
        });

        public ChatMessageDesignModel()
        {
           
        }
    }
}