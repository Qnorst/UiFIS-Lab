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
using TaskSearchWPF.Models;

namespace TaskSearchWPF
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }
        private void RegistrationBtn_Click(object sender, RoutedEventArgs e)
        {
            string Name = NameBox.Text.Trim();
            string SecondName = SecondNameBox.Text.Trim();
            string Nickname = NicknameBox.Text.Trim();
            string Password = PasswordBox.Text.Trim();

            User user = new User()
            {
                UserNick = Nickname,
                UserPassword = Password,
                UserName = Name,
                UserSurname = SecondName,
            };
            Helper.db.Users.Add(user);
            Helper.db.SaveChanges();

            MessageBox.Show("Регистрация успешна");

            new MainWindow().Show();
            this.Close();
        }
    }
}
