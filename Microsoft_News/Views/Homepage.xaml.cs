using Microsoft_News.Models;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Microsoft_News.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Homepage : Page
    {
        public List<News> NewsList { get; set; } = Database.DB.News;
        public static int NewsId { get; set; }

        public Homepage()
        {
            this.InitializeComponent();
        }

        private void Grid_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            Grid grid = sender as Grid;
            NewsId = (int) grid.Tag;
            NewsNavigation.MyFrame.Navigate(typeof(NewsDetail));
        }
    }
}
