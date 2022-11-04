using System.Windows;
using ChatONN.Core;
using Fasetto.Word;

namespace ChatONN.Desktop.ViewModels
{
    public class WindowViewModel : BaseViewModel
    {

        public WindowViewModel(Window window)
        {
            _ = new WindowResizer(window);
        }
    }
}
