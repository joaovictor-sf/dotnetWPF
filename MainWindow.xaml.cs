using Microsoft.Win32;
using System.Windows;

namespace WPFTutorial;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void btnFire_Click(object sender, RoutedEventArgs e) {
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*| CS Source Files | *.cs";
        //openFileDialog.InitialDirectory = "C:\";
        openFileDialog.Title = "Select a file";
        //openFileDialog.Multiselect = true;

        bool? sucess = openFileDialog.ShowDialog();
        if (sucess == true) {
            string path = openFileDialog.FileName;
            string fileName = openFileDialog.SafeFileName;
            //string[] paths = openFileDialog.FileNames;
            //string[] fileNames = openFileDialog.SafeFileNames;

            MessageBox.Show($"You selected: {path}");
            tbInfo.Text = fileName;
        } else {
            MessageBox.Show("No file selected");
        }
    }
}