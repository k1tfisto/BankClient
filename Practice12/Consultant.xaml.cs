using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
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
using System.Windows.Shapes;

namespace Practice12
{
    
    /// <summary>
    /// Логика взаимодействия для Consultant.xaml
    /// </summary>
    public partial class Consultant : Window
    {
        private readonly string path = "Bank.txt";
        ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        
        public Consultant()
        {
            InitializeComponent();

        }

        private void ConslDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] args = sr.ReadLine().Split('#');

                    employees.Add(new Employee(args[0], args[1], args[2], args[3], args[4]));

                    conslDataGrid.ItemsSource = employees;
                    
                }
                
                //conslDataGrid.Columns[4].Visibility = Visibility.Collapsed;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path))
                foreach (var personal in employees)
                {
                    string temp = String.Format("{0}#{1}#{2}#{3}#{4}",
                                            personal.LastName,
                                            personal.FirstName,
                                            personal.MiddleName,
                                            personal.NumberPhone,
                                            personal.Passport);

                    sw.WriteLine($"{temp}");
                }
            MessageBox.Show(
                    "Запись сохранена",
                    this.Title,
                    MessageBoxButton.OK,
                    MessageBoxImage.Information
                    );
        }

        
    }
}
