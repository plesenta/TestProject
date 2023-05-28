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
    /// Логика взаимодействия для Tovar.xaml
    /// </summary>
    /// 
    public partial class Tovar : Window
    {
        string name;
        public Tovar(string name)
        {
            this.name = name;           
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Add_Tovar add_Tovar = new Add_Tovar(name);
            add_Tovar.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            add_Tovar.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Show();
            this.Hide();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            TestDataSet.ProductRow row = (sender as Button).DataContext as TestDataSet.ProductRow;
            int id = row.ID_Product;
            new ProductTableAdapter().DeleteQuery(id);
            MessageBox.Show("Запись была удалена!");
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            TestDataSet.ProductRow row = (sender as Button).DataContext as TestDataSet.ProductRow;
            int id = row.ID_Product;
            string art = row.Articul;
            string nm = row.Name;
            string descrip = row.Description;
            string man = row.Manufacturer;
            int cos = row.Cost;
            string ph = row.Photo;
            int kol = row.QuantityInStock;
            Edit edit = new Edit(name, id, art, nm, descrip, man, cos, ph, kol);
            edit.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            edit.Show();
            this.Hide();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Zakaz add_Tovar = new Zakaz(name);
            add_Tovar.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            add_Tovar.Show();
            this.Hide();
        }
    }
}
