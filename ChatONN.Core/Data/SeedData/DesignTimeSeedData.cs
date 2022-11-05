
using ChatONN.Core.ViewModels;
using System.Collections.ObjectModel;

namespace ChatONN.Core.Data.SeedData
{
    public static class DesignTimeSeedData
    {
        public static ObservableCollection<RecentChatItemViewModel> RecentChats()
        {
            return new ObservableCollection<RecentChatItemViewModel>
            {
                new RecentChatItemViewModel
                {
                    Username = "Ankit Mishra",
                    LastMessage = "Are we meeting today? Lets talk about the progress of our work.",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 3,
                    ProfilePictureUrl = "/Resources/Images/sm/avatar1.jpg",
                    IsSelected = false
                },
                new RecentChatItemViewModel
                {
                    Username = "Ankit Mishra",
                    LastMessage = "Are we meeting today? Lets talk about the progress of our work.",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 2,
                    ProfilePictureUrl = "/Resources/Images/sm/avatar2.jpg",
                    IsSelected = false
                },
                new RecentChatItemViewModel
                {
                    Username = "Ankit Mishra",
                    LastMessage = "Are we meeting today? Lets talk about the progress of our work.",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 1,
                    ProfilePictureUrl = "/Resources/Images/sm/avatar3.jpg",
                    IsSelected = false
                },
                new RecentChatItemViewModel
                {
                    Username = "Ankit Mishra",
                    LastMessage = "Are we meeting today? Lets talk about the progress of our work.",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 2,
                    ProfilePictureUrl = "/Resources/Images/sm/avatar4.jpg",
                    IsSelected = true
                },
                new RecentChatItemViewModel
                {
                    Username = "Ankit Mishra",
                    LastMessage = "Are we meeting today? Lets talk about the progress of our work.",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 2,
                    ProfilePictureUrl = "/Resources/Images/sm/avatar5.jpg",
                    IsSelected = false
                },
                new RecentChatItemViewModel
                {
                    Username = "Ankit Mishra",
                    LastMessage = "Are we meeting today? Lets talk about the progress of our work.",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 0,
                    ProfilePictureUrl = "/Resources/Images/sm/avatar6.jpg",
                    IsSelected = false
                },
                new RecentChatItemViewModel
                {
                    Username = "Ankit Mishra",
                    LastMessage = "Are we meeting today? Lets talk about the progress of our work.",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 2,
                    ProfilePictureUrl = "/Resources/Images/sm/avatar1.jpg",
                    IsSelected = false
                }
            };
        }

        public static ObservableCollection<NotificationItemViewModel> Notifications()
        {
            return new ObservableCollection<NotificationItemViewModel>
            {
                new NotificationItemViewModel
                {
                    Message = "@Ankita Mentioned you in a \"Trip to Goo\"",
                    NotificationTime = DateTimeOffset.UtcNow,
                    UserProfileUrl = "/Resources/Images/sm/avatar1.jpg"
                },
                new NotificationItemViewModel
                {
                    Message = "@Ankita Mentioned you in a \"Trip to Goo\"",
                    NotificationTime = DateTimeOffset.UtcNow,
                    UserProfileUrl = "/Resources/Images/sm/avatar2.jpg"
                },
                new NotificationItemViewModel
                {
                    Message = "@Ankita Mentioned you in a \"Trip to Goo\"",
                    NotificationTime = DateTimeOffset.UtcNow,
                    UserProfileUrl = "/Resources/Images/sm/avatar3.jpg"
                },
                new NotificationItemViewModel
                {
                    Message = "@Ankita Mentioned you in a \"Trip to Goo\"",
                    NotificationTime = DateTimeOffset.UtcNow,
                    UserProfileUrl = "/Resources/Images/sm/avatar4.jpg"
                },
                new NotificationItemViewModel
                {
                    Message = "@Ankita Mentioned you in a \"Trip to Goo\"",
                    NotificationTime = DateTimeOffset.UtcNow,
                    UserProfileUrl = "/Resources/Images/sm/avatar5.jpg"
                },
                new NotificationItemViewModel
                {
                    Message = "@Ankita Mentioned you in a \"Trip to Goo\"",
                    NotificationTime = DateTimeOffset.UtcNow,
                    UserProfileUrl = "/Resources/Images/sm/avatar6.jpg"
                }
            };
        }

        public static ObservableCollection<SuggestionItemViewModel> Suggestions()
        {
            return new ObservableCollection<SuggestionItemViewModel>
            {
                new SuggestionItemViewModel
                {
                    Username = "Abhiman Singh",
                    Message = "12 Mutuals",
                    UserProfileUrl = "/Resources/Images/sm/avatar1.jpg"
                },
                new SuggestionItemViewModel
                {
                    Username = "Abhiman Singh",
                    Message = "16 Mutuals",
                    UserProfileUrl = "/Resources/Images/sm/avatar2.jpg"
                },
                new SuggestionItemViewModel
                {
                    Username = "Abhiman Singh",
                    Message = "2 Mutuals",
                    UserProfileUrl = "/Resources/Images/sm/avatar3.jpg"
                },
                new SuggestionItemViewModel
                {
                    Username = "Abhiman Singh",
                    Message = "2 Mutuals",
                    UserProfileUrl = "/Resources/Images/sm/avatar4.jpg"
                }
            };
        }
    }
}