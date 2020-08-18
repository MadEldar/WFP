using MyServices.Services;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Linq;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MemberRegister.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreateSong : Page
    {
        public CreateSong()
        {
            this.InitializeComponent();
        }

        private void Check_empty(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            StackPanel parent = (StackPanel)textBox.Parent;
            parent.Children.OfType<TextBlock>().FirstOrDefault().Opacity = textBox.Text == "" ? 1 : 0;
        }

        private async void Create_Song(object sender, RoutedEventArgs e)
        {
            foreach (StackPanel child in Form.Children.OfType<StackPanel>().ToList())
            {
                TextBox textBox = child.Children.OfType<TextBox>().FirstOrDefault();
                if (textBox == null) continue;
                else if (textBox.Text == "")
                {
                    child.Children.OfType<TextBlock>().FirstOrDefault().Opacity = 1;
                    return;
                }
            }

            var content = JsonConvert.SerializeObject(new
            {
                name = Name.Text,
                singer = Singer.Text,
                author = Author.Text,
                thumbnail = Thumbnail.Text,
                link = Link.Text,
            });

            var response = await MusicILike.CreateSong(content);

            if (response.status == 1)
            {
                Debug.WriteLine("Created song successfully");
            }
            else
            {
                Debug.WriteLine("Failed");
            }
        }
    }
}
