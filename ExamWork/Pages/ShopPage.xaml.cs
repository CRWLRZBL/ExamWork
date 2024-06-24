using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ExamWork.Pages
{
    /// <summary>
    /// Логика взаимодействия для ShopPage.xaml
    /// </summary>
    public partial class ShopPage : Page
    {
        public ShopPage()
        {
            InitializeComponent();

            var products = new List<Product>()
            {
                new Product{Id = 1, Name = "Chanel No. 5", Description = "Легендарный женский парфюм с нежными нотами цветов и ванили.", Category = "Парфюмерия", Manufacturer = "Chanel", Price= 2399},
                new Product{Id = 2, Name = "MAC Studio Fix Fluid Foundation", Description = "Тональный крем с максимальным покрытием и матовым финишем.", Category = "Косметика", Manufacturer = "MAC",Price= 31999},
                new Product{Id = 3, Name = "Dior Lip Glow", Description = "Уникальный бальзам для губ, который меняет свой оттенок под воздействием pH кожи.", Category = "Косметика", Manufacturer = "Dior", Price= 12799},
            };
            productListView.ItemsSource = products;         
        }

        private void filterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var comboBox = sender as ComboBox;
            var selectedItem = comboBox.SelectedItem as ComboBoxItem;
            var sortOption = selectedItem.Content.ToString();

            var itemsSource = productListView.ItemsSource;

            var collectionView = CollectionViewSource.GetDefaultView(itemsSource);
            collectionView.SortDescriptions.Clear();

            switch (sortOption)
            {
                case "возрастанию цены":
                    collectionView.SortDescriptions.Add(new SortDescription("Price", ListSortDirection.Ascending));
                    break;
                case "убыванию цены":
                    collectionView.SortDescriptions.Add(new SortDescription("Price", ListSortDirection.Descending));
                    break;
                case "дате опубликации":
                    collectionView.SortDescriptions.Add(new SortDescription("PublicationDate", ListSortDirection.Ascending));
                    break;
                case "названию":
                    collectionView.SortDescriptions.Add(new SortDescription("Name", ListSortDirection.Ascending));
                    break;
            }

            collectionView.Refresh();
        }


        private void priceSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (priceSlider.Value == 5000)
            {
                PriceLabel.Content = "Любая цена";
            }
            else
                PriceLabel.Content = priceSlider.Value.ToString();                    
        }
    }
}
