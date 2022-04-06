using System.Windows;
using System.Windows.Controls;

namespace Smart_Home_App.UserControls
{
    public partial class ButtonAdd : UserControl
    {
        public ButtonAdd()
        {
            InitializeComponent();
        }

        public string Caption
        {
            get { return (string)GetValue(CaptionProperty); }
            set { SetValue(CaptionProperty, value); }
        }

        public static readonly DependencyProperty CaptionProperty = DependencyProperty.Register("Caption", typeof(string), typeof(ButtonAdd));

    }
}