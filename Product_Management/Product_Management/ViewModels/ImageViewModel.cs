using Product_Management.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Management.ViewModels
{
    class ImageViewModel
    {
        public List<ProductImage> ImageList { get; set; } = new List<ProductImage>();

        public ImageViewModel()
        {
            ImageList.Add(new ProductImage() { Path = "ms-appx:///Assets/lipstick_1.png" });
            ImageList.Add(new ProductImage() { Path = "ms-appx:///Assets/perfume_1.png" });
            ImageList.Add(new ProductImage() { Path = "ms-appx:///Assets/clock_1.png" });
        }
    }
}
