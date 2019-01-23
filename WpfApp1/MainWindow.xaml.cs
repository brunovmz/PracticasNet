using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Net.Mail;
using System.Reflection;
using System.Text;
using System.Threading;
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
using Microsoft.Win32;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();

        public MainWindow()
        {
             
            InitializeComponent();
            //lista para barra de progreso
            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Title = "Complete this WPF tutorial", Completion = 45 });
            items.Add(new TodoItem() { Title = "Learn C#", Completion = 80 });
            items.Add(new TodoItem() { Title = "Wash the car", Completion = 0 });
            lbTodoList.ItemsSource = items;

            //lista para combobox de colores
            cmbColors.ItemsSource = typeof(Colors).GetProperties();

            //lista para el treeView
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo driveInfo in drives)
                trvStructure.Items.Add(CreateTreeItem(driveInfo));
        }

        private void btnPreviousTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tcSample.SelectedIndex - 1;
            if (newIndex < 0)
                newIndex = tcSample.Items.Count - 1;
            tcSample.SelectedIndex = newIndex;
        }

        private void btnNextTab_Click(object sender, RoutedEventArgs e)
        {
            int newIndex = tcSample.SelectedIndex + 1;
            if (newIndex >= tcSample.Items.Count)
                newIndex = 0;
            tcSample.SelectedIndex = newIndex;
        }

        private void btnSelectedTab_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Selected tab: " + (tcSample.SelectedItem as TabItem).Header);
        }
       
        //propiedades para el cambio de colores en el comboBox
        private void cmbColors_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Color selectedColor = (Color)(cmbColors.SelectedItem as PropertyInfo).GetValue(null, null);
            this.Background = new SolidColorBrush(selectedColor);
        }

        private void btnBlue_Click(object sender, RoutedEventArgs e)
        {
            cmbColors.SelectedItem = typeof(Colors).GetProperty("Blue");
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (cmbColors.SelectedIndex < cmbColors.Items.Count - 1)
                cmbColors.SelectedIndex = cmbColors.SelectedIndex + 1; 
        }

        //traer datos de una DB y mostrarlos en el listView
        private void btnTraer_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=localhost\\SQLEXPRESS; database=Usuario; integrated security = true");
            try
            {
                conexion.Open();
                string query = "select * from usuarios";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataReader usuario = comando.ExecuteReader();
                
                while (usuario.Read())
                { 
                    users.Add(new User() { Name = usuario["Name"].ToString(), Age = (int)usuario["Age"], Mail = usuario["Mail"].ToString()});                   
                }
                lvUsers.ItemsSource = users;
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
        
        private void BtnCargar_Click(object sender, RoutedEventArgs e)
        {
            Cargar cargar = new Cargar();
            cargar.Show();
        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (lvUsers.SelectedItem != null)
                users.Remove(lvUsers.SelectedItem as User);

            SqlConnection conexion = new SqlConnection("server=localhost\\SQLEXPRESS; database=Usuario; integrated security = true");
            try
            {
                conexion.Open();
                string 
            }
            catch
            {
                MessageBox.Show("No se pudo conectar a DB");
            }
            finally
            {
                conexion.Close();
            }
        }

        //propiedaes para el treeView
        private void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            TreeViewItem item = e.Source as TreeViewItem;
            if((item.Items.Count == 1)&&(item.Items[0] is string))
            {
                item.Items.Clear();
                DirectoryInfo expandedDir = null;
                if (item.Tag is DriveInfo)
                    expandedDir = (item.Tag as DriveInfo).RootDirectory;
                if (item.Tag is DirectoryInfo)
                    expandedDir = (item.Tag as DirectoryInfo);
                try
                {
                    foreach (DirectoryInfo subDir in expandedDir.GetDirectories())
                        item.Items.Add(CreateTreeItem(subDir));
                }
                catch { }
            }
        }

        private TreeViewItem CreateTreeItem(object o)
        {
            TreeViewItem item = new TreeViewItem();
            item.Header = o.ToString();
            item.Tag = o;
            item.Items.Add("Loading...");
            return item;
        }
    }
    public class TodoItem
    {
        public string Title { get; set; }
        public int Completion { get; set; }
    }

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Mail { get; set; }
    }

}
