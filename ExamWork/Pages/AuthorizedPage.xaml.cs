using System.Windows;
using System.Windows.Controls;

namespace ExamWork.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthorizedPage.xaml
    /// </summary>
    public partial class AuthorizedPage : Page
    {
        public AuthorizedPage()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, RoutedEventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passPasswordBox.Password;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Incorrect data");
                App.CurrentFrame.Navigate(new ShopPage());
            }
            else
            {
        
            }
        }

        private void guestButton_Click(object sender, RoutedEventArgs e)
        {
            App.CurrentFrame.Navigate(new ShopPage());
        }
    }
}
