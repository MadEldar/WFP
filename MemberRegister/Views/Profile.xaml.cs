using MyServices.Services;
using Newtonsoft.Json.Linq;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MemberRegister.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Profile : Page
    {
        public Profile()
        {
            this.InitializeComponent();
            if (MusicILike.GetToken() != "")
            {
                InitProfile();
            }
        }

        private async void InitProfile()
        {
            var profile = JObject.Parse(await MusicILike.GetProfile());
            Avatar.Source = new BitmapImage(new Uri((string) profile["avatar"], UriKind.Absolute));
            FirstName.Text = (string) profile["firstName"];
            LastName.Text = (string) profile["lastName"];
            Phone.Text = (string) profile["phone"];
            Address.Text = (string) profile["address"];
            Introduction.Text = (string) profile["introduction"] ?? "No introduction";
            Gender.Text = (int) profile["gender"] == 0 ? "Male" : "Female";
            Birthday.Text = (string) profile["birthday"];
            Email.Text = (string) profile["email"];
            CreatedAt.Text = (string) profile["createdAt"];
        }
    }
}
