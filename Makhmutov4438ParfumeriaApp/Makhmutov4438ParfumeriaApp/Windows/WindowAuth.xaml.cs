using Makhmutov4438ParfumeriaApp.Data;
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

namespace Makhmutov4438ParfumeriaApp.Windows
{
    /// <summary>
    /// Логика взаимодействия для WindowAuth.xaml
    /// </summary>
    public partial class WindowAuth : Window
    {
        public WindowAuth()
        {
            InitializeComponent();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new parfumerDbEntitiess())
                {
                    var user = db.Пользователи.First(x => x.Логин == TboxLogin.Text && x.Пароль == TboxPassword.Text);
                    if (user == null)
                    {
                        MessageBox.Show("Такого пользователя не найдено!");
                        return;
                    }
                    MessageBox.Show($"Пользователь {user.Логин} найден.\n Роль: {user.Роль}");
                    if (user.Роль == "Администратор")
                    {
                        WindowAdmin windowAdmin = new WindowAdmin(user);
                        windowAdmin.Show();
                    }
                    if (user.Роль == "Менеджер")
                    {
                        WindowManager windowManager = new WindowManager(user);
                        windowManager.Show();
                    }
                    if (user.Роль == "Клиент")
                    {
                        WindowClient windowClient = new WindowClient(user);
                        windowClient.Show();
                    }
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка! Проверьте введенные данные!");
            }
        }
    }
}
