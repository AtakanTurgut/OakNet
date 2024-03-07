using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OakWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // ComboBox
            List<ComboValue> list = new List<ComboValue>();

            ComboValue item1 = new ComboValue();
            item1.Id = 1;
            item1.Name = "item1";

            ComboValue item2 = new ComboValue();
            item2.Id = 2;
            item2.Name = "item2";

            ComboValue item3 = new ComboValue();
            item3.Id = 3;
            item3.Name = "item3";

            ComboValue item4 = new ComboValue();
            item4.Id = 4;
            item4.Name = "item4";

            list.Add(item1);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);

            cmbFirst.ItemsSource = list;
            cmbFirst.DisplayMemberPath = "Name";
            cmbFirst.SelectedValuePath = "Id";
            cmbFirst.SelectedIndex = -1;

            // ListBox
            List<ListBoxValue> listBoxList = new List<ListBoxValue>();

            ListBoxValue object1 = new ListBoxValue();
            object1.Id = 1;
            object1.Name = "object1";

            ListBoxValue object2 = new ListBoxValue();
            object2.Id = 2;
            object2.Name = "object2";

            ListBoxValue object3 = new ListBoxValue();
            object3.Id = 3;
            object3.Name = "object3";

            ListBoxValue object4 = new ListBoxValue();
            object4.Id = 4;
            object4.Name = "object4";

            listBoxList.Add(object1);
            listBoxList.Add(object2);
            listBoxList.Add(object3);
            listBoxList.Add(object4);

            lbFirst.ItemsSource = listBoxList;
            lbFirst.SelectedValuePath = "Id";
            lbFirst.SelectedIndex = -1;
        }

        private void OakWpfApp_Loaded(object sender, RoutedEventArgs e)
        {
            btnFirst.Content = "Changed";
        }

        private void btnFirst_Click(object sender, RoutedEventArgs e)
        {
            btnFirst.Content = "Second Change";

            Button second = new Button();
            second.Content = "Second Button";
            second.Width = 100;
            second.Height = 60;

            ImageBrush brush = new ImageBrush();
            brush.ImageSource = new BitmapImage(new Uri(@"1.png", UriKind.RelativeOrAbsolute));
            second.Background = brush;
            second.Click += new RoutedEventHandler(second_clicked);

            firstgrid.Children.Add(second);
            /**/

            string txtValue = txtFirst.Text;
            MessageBox.Show(txtValue);
        }

        private void second_clicked(object sender, RoutedEventArgs e)
        {
            WinMain.Title = "Title Change";
        }

        private void txtFirst_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblFirst.Content = txtFirst.Text;
        }

        private void txtFirst_SelectionChanged(object sender, RoutedEventArgs e)
        {
            TextBox selected = sender as TextBox;
            if (selected.SelectedText.Length > 0)
            {
                txtSecond.Text = "Your selected text = " + selected.SelectedText + Environment.NewLine;
                txtSecond.Text += "Your selected text start with = " + selected.SelectionStart + Environment.NewLine;
                txtSecond.Text += "Your selected texts length is = " + selected.SelectionLength;
            }
        }

        private void chkFirst_Checked(object sender, RoutedEventArgs e)
        {
            string MessageText = "";

            if ((bool)chkFirst.IsChecked)
                MessageText = "Ch first is checked";

            MessageBox.Show(MessageText);
        }

        private void chkFirst_Unchecked(object sender, RoutedEventArgs e)
        {
            if ((bool)!chkFirst.IsChecked)
                MessageBox.Show("Ch first is unchecked");
        }

        class ComboValue
        {
            public int Id { get; set; }
            public string? Name { get; set; }
        }

        private void cmbFirst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string messageText = "selected index value = " + cmbFirst.SelectedIndex.ToString() + Environment.NewLine +
                "selected item value = " + cmbFirst.SelectedItem.ToString() + Environment.NewLine + 
                "selected value's value = " + cmbFirst.SelectedValue.ToString();

            MessageBox.Show(messageText);
        }

        class ListBoxValue
        {
            public int Id { get; set; }
            public string? Name { get; set; }
        }

        private void btnListBox_Click(object sender, RoutedEventArgs e)
        {
            string selectedItem, selectedValue, selectedIndex;
            selectedItem = lbFirst.SelectedItem.ToString() + Environment.NewLine;
            selectedValue = lbFirst.SelectedValue.ToString() + Environment.NewLine;
            selectedIndex = lbFirst.SelectedIndex.ToString() + Environment.NewLine;

            var itemsCount = lbFirst.SelectedItems.Count;

            string messageText = selectedItem + selectedValue + selectedIndex + itemsCount;

            MessageBox.Show(messageText);
        }
    }
}