using MyServices.Services;
using Newtonsoft.Json;
using System.Diagnostics;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MemberRegister.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SignIn : Page
    {
        public SignIn()
        {
            this.InitializeComponent();
        }

        private async void Sign_In(object sender, RoutedEventArgs e)
        {
            if (Email.Text == "")
            {
                EmailLabel.Opacity = 1;
                return;
            }
            else if (Password.Password == "")
            {
                PasswordLabel.Opacity = 1;
                return;
            }

            var response = await MusicILike.SignIn(JsonConvert.SerializeObject(new
            {
                email = Email.Text,
                password = Password.Password
            }));

            if (response.status == 1)
            {
                Debug.WriteLine("Logged in successfully");
            }
            else
            {
                Debug.WriteLine("Failed");
            }
        }

        private void Something_Something(object sender, RoutedEventArgs e)
        {
            Blah.IsOpen = true;
        }
    }
}
