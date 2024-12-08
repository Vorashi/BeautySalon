using BeautySalon.DataBase;
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

namespace BeautySalon
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Product _product;
        public MainWindow()
        {
            InitializeComponent();
            UpdateList(BeautySalonlist);
        }

        public void UpdateList(ListView list)
        {
            List<Product> productsList;
            productsList = App.GetContext().Product.ToList();
            list.ItemsSource = productsList;
        }

        private void BeautySalonlist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddBtn.Visibility = Visibility.Visible;
            EditBtn.Visibility = Visibility.Visible;
            HistoryBtn.Visibility = Visibility.Visible;
            _product = BeautySalonlist.SelectedItem as Product;            
        }

        private void AddPage(object sender, RoutedEventArgs e)
        {
           AddEdit AddPage = new AddEdit();
           AddPage.ShowDialog();
           UpdateList(BeautySalonlist);
        }

        private void EditPage(object sender, RoutedEventArgs e) 
        {
            if (_product == null)
            {
                MessageBox.Show("Не выбран партнер");
                return;
            }
            AddEdit EditPage = new AddEdit(_product);
            EditPage.ShowDialog();
            UpdateList(BeautySalonlist);
        }
    }
}
