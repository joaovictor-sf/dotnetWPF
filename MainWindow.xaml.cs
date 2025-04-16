using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace WPFTutorial;

public partial class MainWindow : Window, INotifyPropertyChanged {
    public MainWindow() {
        DataContext = this;
        InitializeComponent();
    }

    private string boundText;

    public event PropertyChangedEventHandler? PropertyChanged;

    public string BoundText {
        get { return boundText; }
        set {
            boundText = value;
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BoundText"));
            //OnPropertyChanged(nameof(BoundText));
            OnPropertyChanged();
        }
    }

    private void btnSet_Click(object sender, RoutedEventArgs e) {
        BoundText = "Hello, World!";
    }

    private void OnPropertyChanged([CallerMemberName]string propertyName = null) {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}