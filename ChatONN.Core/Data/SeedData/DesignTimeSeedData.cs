﻿
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
                    ProfilePictureUrl = ""
                },
                new RecentChatItemViewModel
                {
                    Username = "Ankit Mishra",
                    LastMessage = "Are we meeting today? Lets talk about the progress of our work.",
                    LastMessageTime = DateTimeOffset.Now,
                    UnreadMessageCount = 2,
                    ProfilePictureUrl = ""
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
                    NotificationTime = DateTimeOffset.UtcNow
                },
                new NotificationItemViewModel
                {
                    Message = "@Ankita Mentioned you in a \"Trip to Goo\"",
                    NotificationTime = DateTimeOffset.UtcNow
                },
                new NotificationItemViewModel
                {
                    Message = "@Ankita Mentioned you in a \"Trip to Goo\"",
                    NotificationTime = DateTimeOffset.UtcNow
                }
            };
        }
    }
}