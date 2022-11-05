using ChatONN.Core.Data.SeedData;

namespace ChatONN.Core.ViewModels.Design
{
    public class NotificationListDesignModel : NotificationListViewModel
    {
        public static NotificationListDesignModel Instance { get; set; } = new();

        public NotificationListDesignModel()
        {
            this.Items = DesignTimeSeedData.Notifications();
        }
    }
}