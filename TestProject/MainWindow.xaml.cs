using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace TestProject
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string connectDB = "Data Source= LAPTOP-HV0RLJLE; Initial Catalog = Test; Integrated Security = True;";
            SqlConnection conn = new SqlConnection(connectDB);
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM [User] WHERE [Login] = '" + Login.Text + "' AND [Password] = '" + Password.Password.ToString() + "'", conn);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (!reader.HasRows)
                {
                    MessageBox.Show("Такого пользователя в системе нет!");
                }
                else
                {
                    while (reader.Read())
                    {
                        if (reader["Role_ID"].ToString() == "1")
                        {
                            string name = reader["Name"].ToString();
                            Tovar tovar = new Tovar(name);
                            tovar.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                            tovar.Show();
                            this.Hide();
                        }
                        if (reader["Role_ID"].ToString() == "2")
                        {
                            string name = reader["Name"].ToString();
                            int iduser = Convert.ToInt32(reader["ID_User"].ToString());
                            MenuBughalter tovar = new MenuBughalter(name, iduser);
                            tovar.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                            tovar.Show();
                            this.Hide();
                        }
                        if (reader["Role_ID"].ToString() == "3")
                        {
                            string name = reader["Name"].ToString();
                            int iduser = Convert.ToInt32(reader["ID_User"].ToString());
                            TovarClient tovar = new TovarClient(name, iduser);
                            tovar.WindowStartupLocation = WindowStartupLocation.CenterScreen;
                            tovar.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string name = "Гость";
            int iduser = 7;
            TovarClient tovar = new TovarClient(name, iduser);
            tovar.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            tovar.Show();
            this.Hide();
        }
    }
}
