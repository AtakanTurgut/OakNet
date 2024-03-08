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

namespace OakWpfAppDatagrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public class Person()
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Surname { get; set; }
            public int Age { get; set; }
        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Person> list = new List<Person>();
            list.Add(new Person() { Id = 1, Name = "Atakan", Surname = "Turgut", Age = 22 });
            list.Add(new Person() { Id = 2, Name = "Furkan", Surname = "Üvenç", Age = 25 });
            list.Add(new Person() { Id = 3, Name = "Yağmur", Surname = "Soydan", Age = 21 });
            list.Add(new Person() { Id = 4, Name = "Burak", Surname = "Necali", Age = 28 });
            list.Add(new Person() { Id = 5, Name = "Fatih", Surname = "Turhan", Age = 30 });

            dataGrid.ItemsSource = list;

        }

        private void btnGetValues_Click(object sender, RoutedEventArgs e)
        {
            /*
            Person person = (Person)dataGrid.SelectedItem;
            MessageBox.Show($"Person Id = {person.Id} Name = {person.Name} Surname = {person.Surname}");
            */

            var list = dataGrid.SelectedItems;
            string textValue = "";

            foreach ( var item in list )
            {
                Person person = (Person)item;
                textValue += $"{person.Id} - {person.Name} {person.Surname}" + Environment.NewLine;
            }

            MessageBox.Show(textValue);
        }
    }
}