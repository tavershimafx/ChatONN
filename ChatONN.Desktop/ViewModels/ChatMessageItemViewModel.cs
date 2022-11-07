using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using ChatONN.Core;
using ChatONN.Core.ViewModels;

namespace ChatONN.Desktop.ViewModels
{
    public class ChatMessageItemViewModel<T> : ChatMessageViewModel
    {
        private CornerRadius mMessageCorners; 
        public event PropertyChangedEventHandler? PropertyChanged = delegate { };

        public ChatMessageItemViewModel()
        {
            
        }

        public CornerRadius MessageCorners 
        { 
            get
            {
                return mMessageCorners;
            }
            set
            {
                mMessageCorners = value;
            }
        }
    }
}
