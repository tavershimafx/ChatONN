using System.Windows.Controls;

namespace ChatONN.Desktop.Controls
{
    public class BaseControl : UserControl 
    {

    }

    public class BaseControl<T> : BaseControl where T : class, new()
    {
        private T mViewModel;

        public T ViewModel
        {
            get { return mViewModel; }
            set
            {
                mViewModel = value;
                this.DataContext = value;
            }
        }

        public BaseControl()
        {
            ViewModel = new();
        }
    }
}
