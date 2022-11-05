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
    /// Логика взаимодействия для WindowClient.xaml
    /// </summary>
    public partial class WindowClient : Window
    {
        public WindowClient(Пользователи user)
        {
            InitializeComponent();
            TbUsername.Text = $"{user.Имя} {user.Фамилия}";
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            WindowAuth auth = new WindowAuth();
            auth.Show();
            this.Close();
        }
    }
}
