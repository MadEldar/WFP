using Product_Management.Models;
using System.Collections.ObjectModel;

namespace Product_Management.ViewModels
{
    public class ProductViewModel
    {
        public ObservableCollection<Product> ProductList { get; set; } = new ObservableCollection<Product>();

        public ProductViewModel()
        {
            ProductList.Add(new Product() { Name = "Lipstick", Description = "Lipstick will make you attractive", Image = "ms-appx:///Assets/lipstick_1.png" });
            ProductList.Add(new Product() { Name = "Perfume", Description = "Perfume will make you fragrant", Image = "ms-appx:///Assets/perfume_1.png" });
            ProductList.Add(new Product() { Name = "Clock", Description = "Lake will turn you into a success", Image = "ms-appx:///Assets/clock_1.png" });
        }
    }
}
