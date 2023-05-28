using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using System;
using System.Collections.Generic;
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
using TestProject.TestDataSetTableAdapters;

namespace TestProject
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        public string zakaz;
        int id_CLient;
        int cos;
        public Order(string zakaz, int id_CLient, int cos)
        {
            InitializeComponent();
            this.zakaz = zakaz;
            this.id_CLient = id_CLient;
            this.cos = cos;
            Tovar.Content += " " + zakaz;

            PickPointTableAdapter adapt2 = new PickPointTableAdapter();
            TestDataSet.PickPointDataTable tabl2 = new TestDataSet.PickPointDataTable();
            adapt2.Fill(tabl2);
            PickPoint.ItemsSource = tabl2;
            PickPoint.DisplayMemberPath = "Adress";
            PickPoint.SelectedValuePath = "ID_PickPoint";

            data_order.Content = DateTime.Today.ToString("yyyy-MM-dd");
            data_deliv.Content = DateTime.Today.AddDays(3).ToString("yyyy-MM-dd");

            Random random = new Random();
            Kod.Content = random.Next(100, 999).ToString();

            status.Content = "Не подтверждено";
            CostItog.Content = cos;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tovar.Content = " ";
            data_order.Content = " ";
            data_deliv.Content = " ";
            Kod.Content = " ";
            status.Content = " ";
            MessageBox.Show("Заказ удален!");
            zakaz = " ";
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new OrderTableAdapter().InsertQuery(Convert.ToString(Tovar.Content), Convert.ToDateTime(data_order.Content), Convert.ToDateTime(data_deliv.Content), id_CLient, Convert.ToInt32(PickPoint.SelectedItem.ToString()), Convert.ToInt32(Kod.Content), "Подтверждено");
            MessageBox.Show("Заказ добавлен! Ожидайте");
            zakaz = " ";
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {


        }
    }
}
