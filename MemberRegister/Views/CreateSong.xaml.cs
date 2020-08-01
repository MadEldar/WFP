using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

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

        private void Create_Song(object sender, RoutedEventArgs e)
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

            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic" + "KJt66mJsD01bLozr39N3w7UkZwRiY5JeTDAalxzxL2pocv3Xwc6z22mxZ1MmVsaW");
            var responseString = httpClient.PostAsync(
                "https://2-dot-backup-server-002.appspot.com/_api/v2/songs",
                new StringContent(content, Encoding.UTF8, "application/json")
            ).Result.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<ResponseResult>(responseString);
            Debug.WriteLine(result.token);
        }
    }
}
