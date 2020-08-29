using Product_Management.Models;
using Product_Management.ViewModels;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Product_Management.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProductPage : Page
    {
        public ObservableCollection<Product> ProductList;
        public List<ProductImage> ImageList;

        public ProductPage()
        {
            this.InitializeComponent();
            ProductList = new ProductViewModel().ProductList;
            ImageList = new ImageViewModel().ImageList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (TextBox textbox in ProductForm.Children.OfType<TextBox>().ToList())
            {
                if (textbox.Text != "") continue;
                else return;
            }
            this.ProductList.Add(new Product() { Name = Name.Text, Description = Description.Text, Image = ((ProductImage)Image.SelectedValue).Path });
        }
    }
}
