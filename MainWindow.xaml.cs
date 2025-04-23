using System.Windows;

namespace WPFTutorial;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void Window_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e) {
        DragMove();
    }

    private void btnMimimize_Click(object sender, RoutedEventArgs e) {
        WindowState = WindowState.Minimized;
    }

    private void btnMaximize_Click(object sender, RoutedEventArgs e) {
        if(WindowState == WindowState.Maximized) {
            WindowState = WindowState.Normal;
        } else {
            WindowState = WindowState.Maximized;
        }
    }

    private void btnClose_Click(object sender, RoutedEventArgs e) {
        Close();
    }
}