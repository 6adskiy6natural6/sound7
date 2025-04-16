using sound.Interfaces;
using sound.Classes;
using sound.Models.ModelDB;
using System.Windows;


namespace sound
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        private auth _auth;

        public AuthWindow()
        {

            InitializeComponent();
            _auth = new ClassAuth();
        }
        private void button_Click1(object sender, RoutedEventArgs e)
        {
            string login = tbxlogin.Text;
            string password = tbxpass.Text;
            if (_auth.auth(login, password))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


    }
}
