using ChatONN.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;

namespace ChatONN.Desktop.ValueConverters
{
    public class MessageToCornerRadiusConverter : BaseValueConverter<MessageToCornerRadiusConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is ChatMessageViewModel message)
            {
                CornerRadius radius;
                if (message.IsSentByMe)
                {
                    // a, e and f, g
                    if (message.IsSentByMe && message.Previous == null && message.Next == null || // e
                        message.IsSentByMe && message.Next != null && !message.Next.IsSentByMe && message.Previous == null || // a
                        message.IsSentByMe && message.Previous != null && !message.Previous.IsSentByMe &&
                        message.Next != null && !message.Next.IsSentByMe || // f
                        message.IsSentByMe && message.Previous != null && !message.Previous.IsSentByMe && message.Next == null) // g
                    {
                        radius = new CornerRadius(20, 20, 20, 20);
                    }
                    // b
                    else if (message.IsSentByMe && message.Next != null && message.Next.IsSentByMe && message.Previous == null ||
                        message.IsSentByMe && message.Next != null && message.Next.IsSentByMe && message.Previous != null && !message.Previous.IsSentByMe)// h
                    {
                        radius = new CornerRadius(20, 20, 0, 20);
                    }
                    // c
                    else if (message.IsSentByMe && message.Previous != null && message.Previous.IsSentByMe && message.Next != null
                        && !message.Next.IsSentByMe ||
                        message.IsSentByMe && message.Previous != null && message.Previous.IsSentByMe && message.Next == null)
                    {
                        radius = new CornerRadius(20, 0, 20, 20);
                    }
                    // d
                    else if (message.IsSentByMe && message.Previous != null && message.Previous.IsSentByMe &&
                        message.Next != null && message.Next.IsSentByMe)
                    {
                        radius = new CornerRadius(20, 0, 0, 20);
                    }
                }
                else if (!message.IsSentByMe)
                {
                    // a, e and f, g
                    if (!message.IsSentByMe && message.Previous == null && message.Next == null || // e
                        !message.IsSentByMe && message.Next != null && message.Next.IsSentByMe && message.Previous == null || // a
                        !message.IsSentByMe && message.Previous != null && message.Previous.IsSentByMe &&
                        message.Next != null && message.Next.IsSentByMe || // f
                        !message.IsSentByMe && message.Previous != null && message.Previous.IsSentByMe && message.Next == null) // g
                    {
                        radius = new CornerRadius(20, 20, 20, 20);
                    }
                    // b
                    else if (!message.IsSentByMe && message.Next != null && message.Next.IsSentByMe && message.Previous == null ||
                        !message.IsSentByMe && message.Next != null && !message.Next.IsSentByMe && message.Previous != null && message.Previous.IsSentByMe)// h
                    {
                        radius = new CornerRadius(20, 20, 20, 0);
                    }
                    // c
                    else if (!message.IsSentByMe && message.Previous != null && !message.Previous.IsSentByMe && message.Next != null
                        && message.Next.IsSentByMe ||
                        !message.IsSentByMe && message.Previous != null && !message.Previous.IsSentByMe && message.Next == null)
                    {
                        radius = new CornerRadius(0, 20, 20, 20);
                    }
                    // d
                    else if (!message.IsSentByMe && message.Previous != null && !message.Previous.IsSentByMe &&
                        message.Next != null && !message.Next.IsSentByMe)
                    {
                        radius = new CornerRadius(0, 20, 20, 0);
                    }
                }

                return radius;
            }

            return new CornerRadius(20, 20, 20, 20);
        }
    }
}
