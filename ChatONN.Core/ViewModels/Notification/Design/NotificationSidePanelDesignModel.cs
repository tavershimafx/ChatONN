using ChatONN.Core.Data.SeedData;

namespace ChatONN.Core.ViewModels.Design
{
    public class NotificationSidePanelDesignModel : NotificationSidePanel
    {
        public static NotificationSidePanelDesignModel Instance { get; set; } = new();

        public NotificationSidePanelDesignModel()
        {
            this.Notifications = new() { Items = DesignTimeSeedData.Notifications() };
        }
    }
}