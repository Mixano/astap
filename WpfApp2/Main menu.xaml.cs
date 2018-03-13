using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BibleThump knigi = new BibleThump() { izdatelstvo = "Mr.Block_developers", Address_izdania = "Красный проспект", book_Name = "Программирование для чайников", Age_izdania = 2018, avtor = "Блок.И.Н" };

        ObservableCollection<BibleThump> students = new ObservableCollection<BibleThump>();
        public MainWindow()
        {
            InitializeComponent();
            //listStudents.ItemsSource = students;

            DataContext = knigi;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Имя: {knigi.book_Name} Возраст: {knigi.Age_izdania}");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            students.Add(knigi);
            knigi = new BibleThump();
            DataContext = knigi;
        }

        private void dataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
