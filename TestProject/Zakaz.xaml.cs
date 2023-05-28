using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using TestProject.TestDataSetTableAdapters;
using static TestProject.TestDataSet;

namespace TestProject
{
    /// <summary>
    /// Логика взаимодействия для Zakaz.xaml
    /// </summary>
    public partial class Zakaz : Window
    {
        string name;
        public Zakaz(string name)
        {
            this.name = name;
            InitializeComponent();
            UserNames.Content = name;
            OrderTableAdapter order = new OrderTableAdapter();
            TestDataSet testDataSet = new TestDataSet();
            order.Fill(testDataSet.Order);
            OrderDataTable orderRows = new OrderDataTable();
            order.Fill(orderRows);

            ObservableCollection<DataRow> ts = new ObservableCollection<DataRow>();

            ListTovar.Items.Clear();

            foreach (DataRow row in orderRows.Rows)
            {
                ts.Add(row);
            }

            ListTovar.ItemsSource = ts;

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Show();
            this.Hide();
        }
    }
}
