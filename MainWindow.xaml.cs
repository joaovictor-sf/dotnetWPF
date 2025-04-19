using System.Windows;
using System.Windows.Controls;

namespace WPFTutorial;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        // Default list for testing
        lvEntreis.Items.Add(new ListViewItem()
        {
            Content = new TextBlock()
            {
                Text = "Test 1",
                FontSize = 20
            }
        });
        lvEntreis.Items.Add(new ListViewItem()
        {
            Content = new TextBlock()
            {
                Text = "Test 2",
                FontSize = 20
            }
        });
        lvEntreis.Items.Add(new ListViewItem()
        {
            Content = new TextBlock()
            {
                Text = "Test 3",
                FontSize = 20
            }
        });
        lvEntreis.Items.Add(new ListViewItem()
        {
            Content = new TextBlock()
            {
                Text = "Test 4",
                FontSize = 20
            }
        });
        lvEntreis.Items.Add(new ListViewItem()
        {
            Content = new TextBlock()
            {
                Text = "Test 5",
                FontSize = 20
            }
        });
    }

    private void btnAdd_Click(object sender, RoutedEventArgs e) {
        if (string.IsNullOrWhiteSpace(txtEntry.Text)) {
            return;
        }
        lvEntreis.Items.Add(new ListViewItem()
        {
            Content = new TextBlock()
            {
                Text = txtEntry.Text,
                FontSize = 20
            }
        });
        txtEntry.Clear();
    }

    private void btnDelete_Click(object sender, RoutedEventArgs e) {
       //Erro
        /*var items = lvEntreis.SelectedItem; ;

        if (items != null) {
            var selectedItems = lvEntreis.SelectedItems.Cast<ListViewItem>().ToList();
            foreach (var item in selectedItems) {
                lvEntreis.Items.Remove(item);
            }
        }*/

        object selectedItem = lvEntreis.SelectedItem;

        if (selectedItem != null) {
            lvEntreis.Items.Remove(selectedItem);
        }


        // Whats is better?
        /*
         int index = lvEntreis.SelectedIndex;
            if (index != -1) {
                lvEntreis.Items.RemoveAt(index);
            }
         */
        // Or this?
        /*if (lvEntreis.SelectedItem != null) {
            lvEntreis.Items.Remove(lvEntreis.SelectedItem);
        }*/
        // Or this?
        /*
        object selectedItem = lvEntreis.SelectedItem;
        if (selectedItem != null) {
            lvEntreis.Items.Remove(selectedItem);
        }*/
        // Answer: The first one is better because it uses the index to remove the item, which is more efficient than searching for the item in the list. The second and third options are less efficient because they require searching for the item in the list, which can be slower if the list is large.
    }

    private void btnClear_Click(object sender, RoutedEventArgs e) {
        lvEntreis.Items.Clear();
    }
}