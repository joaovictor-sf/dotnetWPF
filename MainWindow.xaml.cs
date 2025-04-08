using System.Windows;

namespace WPFTutorial;

public partial class MainWindow : Window
{
    bool isRunning = false;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void btnRun_Click(object sender, RoutedEventArgs e) {
        if (isRunning) {
            tbHello.Text = "Hello World!";
        } else {
            tbHello.Text = "Goodbye World!";
        }
        isRunning = !isRunning;
    }
}