using Microsoft_News.Models;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace Microsoft_News.Views
{
    public sealed partial class NewsNavigation : Page
    {
        public static int NewsId { get; set; }
        private double NavViewCompactModeThresholdWidth { get { return NavView.CompactModeThresholdWidth; } }
        public static Frame MyFrame { get; set; }
        public List<Category> CategoryList { get; set; } = Database.DB.Categories;

        public NewsNavigation()
        {
            this.InitializeComponent();
            MyFrame = ContentFrame;
            MyFrame.Navigate(typeof(Homepage));
        }
    }
}
