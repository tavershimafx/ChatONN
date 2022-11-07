
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
                    Username = "Zinabe",
                    LastMessage = "Are we meeting today? Lets talk about the progress of our work.",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 3,
                    ProfilePictureUrl = "/Resources/Images/sm/avatar1.jpg",
                    IsSelected = false
                },
                new RecentChatItemViewModel
                {
                    Username = "Tari",
                    LastMessage = "I've mailed you the file. Check your inbox.",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 2,
                    ProfilePictureUrl = "/Resources/Images/sm/avatar2.jpg",
                    IsSelected = false
                },
                new RecentChatItemViewModel
                {
                    Username = "Kosi",
                    LastMessage = "Last night party was awesome. Wish we could have some more time together.",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 1,
                    ProfilePictureUrl = "/Resources/Images/sm/avatar3.jpg",
                    IsSelected = false
                },
                new RecentChatItemViewModel
                {
                    Username = "Hemen",
                    LastMessage = "Are you there?",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 2,
                    ProfilePictureUrl = "/Resources/Images/sm/avatar4.jpg",
                    IsSelected = true
                },
                new RecentChatItemViewModel
                {
                    Username = "Tibobo",
                    LastMessage = "Bro, I need your help. Call me.",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 2,
                    ProfilePictureUrl = "/Resources/Images/sm/avatar5.jpg",
                    IsSelected = false
                },
                new RecentChatItemViewModel
                {
                    Username = "Chioma",
                    LastMessage = "Hey, will you go to party with me this weekend?",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 0,
                    ProfilePictureUrl = "/Resources/Images/sm/avatar6.jpg",
                    IsSelected = false
                },
                new RecentChatItemViewModel
                {
                    Username = "Maudlin",
                    LastMessage = "Sweethear, how have you been?",
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

        public static ObservableLinkedList ChatMessages()
        {
            return new ObservableLinkedList(Messages());
        }

        public static IEnumerable<ChatMessageViewModel> Messages()
        {
            return new List<ChatMessageViewModel>
            {
                new ChatMessageViewModel
                {
                    IsSentByMe = true,
                    Message = "Hey! listen",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = true,
                    Message = "I really like your idea, but I still think we can do more in this",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = true,
                    Message = "I will share something.",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = false,
                    Message = "Let's together work on this and create something more awesome.",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = false,
                    Message = "Sounds perfect.",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = true,
                    Message = "So can you come to my place at around 8PM today?",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = false,
                    Message = "I'll be there.",
                    MessageTime = DateTimeOffset.Now
                },


                new ChatMessageViewModel
                {
                    IsSentByMe = false,
                    Message = "Hey! listen",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = false,
                    Message = "I really like your idea, but I still think we can do more in this",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = false,
                    Message = "I will share something.",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = true,
                    Message = "Let's together work on this and create something more awesome.",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = false,
                    Message = "Sounds perfect.",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = false,
                    Message = "So can you come to my place at around 8PM today?",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = true,
                    Message = "I'll be there.",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = true,
                    Message = "So can you come to my place at around 8PM today?",
                    MessageTime = DateTimeOffset.Now
                },
                new ChatMessageViewModel
                {
                    IsSentByMe = true,
                    Message = "So can you come to my place at around 8PM today?",
                    MessageTime = DateTimeOffset.Now
                }
            };
        }
    }
}