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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Cargar.xaml
    /// </summary>
    public partial class Cargar : Window
    {
        public Cargar()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=localhost\\SQLEXPRESS; database=Usuario; integrated security = true");
            try
            {
                conexion.Open();
                string name = txtName.Text;
                string age = txtAge.Text;
                string mail = txtMail.Text;
                string cadena = "insert into usuarios(Name, Age, Mail) values ('" + name + "', " + age + ", '" + mail + "')";
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                MessageBox.Show("Datos guardados correctamente");
                txtName.Text = "";
                txtAge.Text = "";
                txtMail.Text = "";
            }
            catch
            {
                MessageBox.Show("no se pudo conectar a la DB");
            }
            finally
            {
                conexion.Close();
            }
        }

        private void BtnCanel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
