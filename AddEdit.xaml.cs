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
using System.Windows.Shapes;

namespace BeautySalon
{
    /// <summary>
    /// Логика взаимодействия для AddEdit.xaml
    /// </summary>
    public partial class AddEdit : Window
    {
        private Product _newProduct;
        private Product _selectedProduct;
        private readonly BeautySalonEntities _context;
        public AddEdit(Product _product = null)
        {
            InitializeComponent();
            _context = App.GetContext();
            if (_product != null)
            {
                DataContext = _product;
                _selectedProduct = _product;
                return;
            }
            _newProduct = new Product();
            DataContext = _newProduct;
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_newProduct != null)
                {
                    _context.Product.Add(_newProduct);
                }
                _context.SaveChanges();
                MessageBox.Show("Успешно сохранено");
            }
            catch
            {
                MessageBox.Show("Не удалось сохранить");
            }
        }

        private void ClearBtn_Click(object sender, RoutedEventArgs e)
        {
            Name.Clear();
            Rating.Clear();
            Address.Clear();
            Director.Clear();
            Phone.Clear();
        }
    }
}
