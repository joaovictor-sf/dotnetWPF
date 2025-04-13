using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTutorial.View.UserControls
{
    /// <summary>
    /// Interaction logic for ClearableTextBox.xaml
    /// </summary>
    public partial class ClearableTextBox : UserControl
    {
        public ClearableTextBox()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty PlaceHolderProperty =
            DependencyProperty.Register(
                "PlaceHolder",
                typeof(string),
                typeof(ClearableTextBox),
                new PropertyMetadata(string.Empty));

        public string PlaceHolder {
            get { return (string)GetValue(PlaceHolderProperty); }
            set {
                SetValue(PlaceHolderProperty, value);
                tbPlaceHolder.Text = value;
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e) {
            TxtInput.Clear();
            TxtInput.Focus();
        }

        private void TxtInput_TextChanged(object sender, TextChangedEventArgs e) {
            if (string.IsNullOrEmpty(TxtInput.Text)) {
                tbPlaceHolder.Visibility = Visibility.Visible;
            } else {
                tbPlaceHolder.Visibility = Visibility.Hidden;
            }
        }
    }
}
