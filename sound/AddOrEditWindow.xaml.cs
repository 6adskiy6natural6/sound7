
using sound.Models.ModelDB;
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

namespace sound
{
    /// <summary>
    /// Логика взаимодействия для AddOrEditWindow.xaml
    /// </summary>
    public partial class AddOrEditWindow : Window
    {
        private shopdb12RukosuevEntities _dbContext;
        public Products _product;
        public AddOrEditWindow(Products product, shopdb12RukosuevEntities dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _product = product;
            if (product != null)
            {
                txbProductName.Text = product.ProductName;
                txbPrice.Text = product.Price.ToString();
                txbDescription.Text = product.Description;
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txbProductName.Text) || string.IsNullOrEmpty(txbPrice.Text) || string.IsNullOrEmpty(txbDescription.Text))
                {
                    MessageBox.Show("Заполните все поля!");

                }
                if (!decimal.TryParse(txbPrice.Text, out decimal price))
                {
                    MessageBox.Show("Введите корректную цену товара");

                    return;
                }



                if (_product == null)

                {

                    _product = new Products

                    {

                        ProductName = txbProductName.Text,

                        Price = price,

                        Description = txbDescription.Text

                    };

                    _dbContext.Products.Add(_product); // Добавляем в базу данных

                }

                else

                {

                    // Если товар существует, обновляем его данные

                    _product.ProductName = txbProductName.Text;

                    _product.Price = price;

                    _product.Description = txbDescription.Text;

                }


                _dbContext.SaveChanges(); // Сохраняем изменения

                DialogResult = true; // Закрываем окно с результатом true

                Close();

            }

            catch (Exception ex)

            {
                MessageBox.Show($"Ошибка при сохранении товара: {ex.Message}");
            }
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)

        {

            try

            {

                // Проверка введенных данных

                if (string.IsNullOrEmpty(txbProductName.Text))

                {

                    MessageBox.Show("Введите название товара.");

                    return;

                }


                if (!decimal.TryParse(txbPrice.Text, out decimal price))

                {

                    MessageBox.Show("Введите корректную цену товара.");

                    return;

                }


                // Если товар новый, создаем его

                if (_product == null)

                {

                    _product = new Products

                    {

                        ProductName = txbProductName.Text,

                        Price = price,

                        Description = txbDescription.Text

                    };

                    _dbContext.Products.Add(_product); // Добавляем в базу данных

                }

                else

                {

                    // Если товар существует, обновляем его данные

                    _product.ProductName = txbProductName.Text;

                    _product.Price = price;

                    _product.Description = txbDescription.Text;

                }


                _dbContext.SaveChanges(); // Сохраняем изменения

                DialogResult = true; // Закрываем окно с результатом true

                Close();

            }

            catch (Exception ex)

            {

                MessageBox.Show($"Ошибка при сохранении товара: {ex.Message}");

            }

        }

    }

}
