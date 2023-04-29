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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AppppppppppppExam
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>()
            { 
                new Product(1000,"Фигурка Эрена","Размер 20 * 20"),
                new Product(3000,"Брелок","Размер 4 * 4"),
                new Product(3560,"Фигурка Эрена","Размер 50 * 20")
            };
            productList.ItemsSource = products;
        }

        private void Add(object sender, RoutedEventArgs e)
        {
          
        }

        private void Edit(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            var prod = productList.SelectedItem as Product;
            if (prod == null) return;
            products.Remove(prod);
            productList.Items.Refresh();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Search.Text == "") productList.ItemsSource = products; ;
            var prod = products.Where(u => u.Name.ToLower().Contains(Search.Text.ToLower().ToString()));
            productList.ItemsSource = prod;
        }
    }
}
