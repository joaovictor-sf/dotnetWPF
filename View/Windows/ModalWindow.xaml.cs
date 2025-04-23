using System.Windows;

namespace WPFTutorial.View.Windows
{
    public partial class ModalWindow : Window
    {
        public bool Success { get; set; }
        public string Input { get; set; }

        public ModalWindow(Window parentalWindow)
        {
            Owner = parentalWindow;
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e) {
            Success = true;
            Input = txtIput.Text;
            Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e) {
            Close();
        }

        private void txtIput_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e) {
            if(!string.IsNullOrEmpty(txtIput.Text)) {
                btnOK.IsEnabled = true;
            } else {
                btnOK.IsEnabled = false;
            }
        }
    }
}
