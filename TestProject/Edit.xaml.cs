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
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        string filename;
        string name;
        int id;
        public Edit(string name, int id, string art, string nm, string descrip, string man, int cos, string ph, int kol)
        {
            this.name = name;
            this.id = id;
            InitializeComponent();
            articul.Text = art;
            TovarName.Text = nm;
            Descrip.Text = descrip;
            Manufacturer.Text = man;
            Cost.Text = Convert.ToString(cos);
            pich.Text = ph;
            Kolvo.Text = Convert.ToString(kol);
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tovar tovar = new Tovar(name);
            tovar.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            tovar.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new ProductTableAdapter().UpdateQuery(articul.Text, TovarName.Text, Descrip.Text, Manufacturer.Text, Convert.ToInt32(Cost.Text), pich.Text, Convert.ToInt32(Kolvo.Text), id);
            MessageBox.Show("Товар изменен!");
        }
    }
}
