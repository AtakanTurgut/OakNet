using OakWpfAppUserControl.ViewModels;
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

namespace OakWpfAppUserControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Default
            TextViewModel model = new TextViewModel();
            DataContext = model;
        }

        private void btnTextBox_Click(object sender, RoutedEventArgs e)
        {
            TextViewModel model = new TextViewModel();
            DataContext = model;
        }

        private void btnComboBox_Click(object sender, RoutedEventArgs e)
        {
            ComboViewModel model = new ComboViewModel();
            DataContext = model;
        }

        private void btnDataPicker_Click(object sender, RoutedEventArgs e)
        {
            DatePickerViewModel model = new DatePickerViewModel();
            DataContext = model;
        }

        private void btnLabel_Click(object sender, RoutedEventArgs e)
        {
            LabelViewModel model = new LabelViewModel();
            DataContext = model;
        }

    }
}