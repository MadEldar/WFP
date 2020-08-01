using Newtonsoft.Json;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
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

        private void Sign_In(object sender, RoutedEventArgs e)
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

            var content = JsonConvert.SerializeObject(new {
                email = Email.Text,
                password = Password.Password
            });

            var responseString = new HttpClient().PostAsync(
                "https://2-dot-backup-server-002.appspot.com/_api/v2/members/authentication",
                new StringContent(content, Encoding.UTF8, "application/json")
            ).Result.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<ResponseResult>(responseString);
            Debug.WriteLine(result.token);
        }
    }
}
