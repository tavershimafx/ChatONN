namespace ChatONN.Core.ViewModels.Design
{
    public class NotificationItemDesignModel : NotificationItemViewModel
    {
        public static NotificationItemDesignModel Instance { get; set; } = new();
        public NotificationItemDesignModel()
        {
            Message = "Are we meeting today? Lets talk about the progress of our work.";
            NotificationTime = DateTimeOffset.Now;
            UserProfileUrl = @"\Resources\Images\sm\avatar1.jpg";
        }
    }
}