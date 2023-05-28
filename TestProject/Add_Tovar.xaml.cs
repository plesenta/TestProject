using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для Add_Tovar.xaml
    /// </summary>
    public partial class Add_Tovar : Window
    {
        string name;
        string filename;
        public Add_Tovar(string name)
        {
            this.name = name;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tovar tovar = new Tovar(name);
            tovar.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            tovar.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                filename = openFileDialog.SafeFileName;
                pich.Text = filename;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new ProductTableAdapter().InsertQuery(articul.Text, TovarName.Text, Descrip.Text, Manufacturer.Text, Convert.ToInt32(Cost.Text), pich.Text, Convert.ToInt32(Kolvo.Text));
            MessageBox.Show("Товар добавлен!");
        }
    }
}
