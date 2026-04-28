using mvvm_test.Model;
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

namespace mvvm_test.View
{
    /// <summary>
    /// Логика взаимодействия для ViewGuest.xaml
    /// </summary>
    public partial class ViewGuest : Window
    {
        КалиевПрактикаEntities db = new КалиевПрактикаEntities();
        public ViewGuest()
        {
            InitializeComponent();
            TovarList.ItemsSource = db.Товары.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            this.Close();
        }
    }
}
