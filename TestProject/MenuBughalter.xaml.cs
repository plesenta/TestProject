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
    /// Логика взаимодействия для MenuBughalter.xaml
    /// </summary>
    public partial class MenuBughalter : Window
    {
        string name;
        int id_CLient;
        public MenuBughalter(string name, int id_CLient)
        {
            this.name = name;
            this.id_CLient = id_CLient;
            InitializeComponent();
            UserNames.Content = name;

            ProductTableAdapter tableAdapter = new ProductTableAdapter();
            TestDataSet dataSet = new TestDataSet();
            tableAdapter.Fill(dataSet.Product);
            ProductDataTable dataTable = new ProductDataTable();
            tableAdapter.Fill(dataTable);

            ObservableCollection<DataRow> dataRows = new ObservableCollection<DataRow>();

            ListTovar.Items.Clear();

            foreach (DataRow row in dataTable.Rows)
            {
                dataRows.Add(row);
            }

            ListTovar.ItemsSource = dataRows;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Zakaz add_Tovar = new Zakaz(name);
            add_Tovar.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            add_Tovar.Show();
            this.Hide();
        }
    }
}
