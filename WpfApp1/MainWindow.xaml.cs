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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                Name = "Стиральная машинка",

                Sale = 10000,

                Pict = 1,
                ProductType = ProductTypes.Tech
            });

            products.Add(new Product()
            {
                Name = "Пицца",

                Sale = 500,

                Pict = 2,
                ProductType = ProductTypes.Food
            });

            products.Add(new Product()
            {
                Name = "Холодильник ",

                Sale = 12000,

                Pict = 3,
                ProductType = ProductTypes.Tech
            });





            lstBox.ItemsSource = products;

        }
    }
}
