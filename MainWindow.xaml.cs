using System.Windows;

namespace WPFTutorial;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void btnDetails_Click(object sender, RoutedEventArgs e) {
        ExpanderDetails.IsExpanded = !ExpanderDetails.IsExpanded;
    }
}