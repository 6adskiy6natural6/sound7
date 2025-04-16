using sound.Classes;
using sound.Models.ModelDB;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

namespace sound
{
    public partial class DataGrid : Window
    {
        shopdb12RukosuevEntities dbContext = new shopdb12RukosuevEntities();
        private Users currentUser;
        public ClassRole role;
        public DataGrid(Users user)
        {
            InitializeComponent();
            LoadData();
            currentUser = user;
            role = new ClassRole();
        }

        private void LoadData()
        {
            try
            {
                Products.ItemsSource = dbContext.Products.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);

            }
        }


        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Window Exit = new AuthWindow();
            Exit.Show();
            Close();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (Products.SelectedItem is Products selected)
            {
                var ar = MessageBox.Show("Вы хотите удалить продукт?", "Внимание", MessageBoxButton.YesNo);
                if (ar == MessageBoxResult.Yes)
                {
                    dbContext.Products.Remove(selected);
                    dbContext.SaveChanges();
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Товар не выбран");
                }
            }
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduct = Products.SelectedItem as Products;

            if (selectedProduct == null)

            {

                MessageBox.Show("Выберите товар для редактирования.");

                return;

            }

            var editWindow = new AddOrEditWindow(selectedProduct, dbContext);

            if (editWindow.ShowDialog() == true)

            {

                LoadData();

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            TextCheck.Text = $"{currentUser.Roles.RoleN}";
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            Window AddWindow = new AddOrEditWindow(default, dbContext);
            if (AddWindow.ShowDialog() == true)
            {
                dbContext.SaveChanges();
                LoadData();
                MessageBox.Show("Успешно добавлено");
            }
            else
            {
                MessageBox.Show("Ошибка добавления");
            }
        }
    }
}

