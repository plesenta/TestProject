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
    /// Логика взаимодействия для TovarClient.xaml
    /// </summary>
    public partial class TovarClient : Window
    {
        string zakaz;
        string name;
        int id, cos, kol, id_CLient;
        string art; 
        string nm, descrip, man, ph;
        List<dynamic> myList = new List<dynamic>();
        public TovarClient(string name, int id_CLient)
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

        private void btnMenu_Click(object sender, RoutedEventArgs e)
        {
            if (id_CLient == 7)
            {
                MessageBox.Show("Авторизуйтесь, чтобы добавлять заказы!");
            }
            else
            {
                TestDataSet.ProductRow row = (sender as Button).DataContext as TestDataSet.ProductRow;
                id = row.ID_Product;
                art = " " + row.Articul;
                nm = " " + row.Name;
                cos += row.Cost;
                zakaz += nm + art;
                btn_order.Visibility = Visibility.Visible;
                MessageBox.Show("Товар был добавлен в заказ");
            }
            
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            Order order = new Order(zakaz, id_CLient, cos);
            order.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            order.ShowDialog();

            zakaz = order.zakaz;
        }
    }
}
