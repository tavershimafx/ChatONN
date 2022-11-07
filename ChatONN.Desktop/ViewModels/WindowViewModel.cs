using System.Windows;
using ChatONN.Core;
using Fasetto.Word;

namespace ChatONN.Desktop.ViewModels
{
    public class WindowViewModel : BaseViewModel
    {

        #region Public Properties
        /// <summary>
        /// The window's minimum height
        /// </summary>
        public double MinHeight { get; set; } = 500;

        /// <summary>
        /// The window's minimum width
        /// </summary>
        public double MinWidth { get; set; } = 700;

        #endregion

        public WindowViewModel(Window window)
        {
            _ = new WindowResizer(window);
            window.StateChanged += Window_StateChanged; ;
        }

        private void Window_StateChanged(object? sender, System.EventArgs e)
        {
            NotifyPropertyChaged(nameof(MinHeight));
            NotifyPropertyChaged(nameof(MinWidth));
        }
    }
}
