using mvvm_test.ViewModel;
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
    /// Логика взаимодействия для ViewTovar.xaml
    /// </summary>
    public partial class ViewTovar : Window
    {
        public ViewTovar(vmTovar vmTovar)
        {
            InitializeComponent();
            DataContext = vmTovar;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.Owner != null)
            {
                this.Owner.Show();
            }
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddTovar addTovar = new AddTovar();
            addTovar.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddOrders addOrders = new AddOrders();
            addOrders.Show();
        }
    }
}
