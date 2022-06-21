using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
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
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
            LoadData();
            User currentUser;
            currentUser = Helper.userSession;
            DataContext = currentUser;
        }

        private void LoadData()
        {
            UserFormsDGrid.ItemsSource = Helper.db.UserForms.Where(x => x.UserId == Helper.userSession.UserId).ToList();
            
        }

        private void CreateFormBtn_Click(object sender, RoutedEventArgs e)
        {
            new FormCreateWindow().Show();
            this.Close();
            SaveFileDialog saveFile = new SaveFileDialog();
        }
        private void LogOutBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
