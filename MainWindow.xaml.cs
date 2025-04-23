using System.Windows;
using WPFTutorial.View.Windows;

namespace WPFTutorial;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private void btnNormal_Click(object sender, RoutedEventArgs e) {
        NormalWindow normalWindow = new NormalWindow();
        normalWindow.Show(); // Abre uma nova janela normal(não modal), ou seja, a janela atual não fica bloqueada. Se a janela atual for fechada, a nova janela ainda estará aberta.
    }

    private void btnModal_Click(object sender, RoutedEventArgs e) {
        ModalWindow modalWindow = new ModalWindow(this);
        Opacity = 0.5;
        modalWindow.ShowDialog(); // Abre uma nova janela modal, em outras palavras, a janela atual fica bloqueada até que a janela modal seja fechada
        Opacity = 1;

        if (modalWindow.Success) {
            txtInput.Text = modalWindow.Input;
        }
    }
}