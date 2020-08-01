using MemberRegister.Entities;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MemberRegister
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Register : Page
    {
        public Register()
        {
            this.InitializeComponent();
        }

        private void Register_member(object sender, RoutedEventArgs e)
        {
            foreach (StackPanel child in Form.Children.OfType<StackPanel>().ToList())
            {
                TextBox textBox = child.Children.OfType<TextBox>().FirstOrDefault();
                if (textBox == null) continue;
                else if(textBox.Text == "")
                {
                    child.Children.OfType<TextBlock>().FirstOrDefault().Opacity = 1;
                    return;
                }
            }
            if (Confirm.Password != Password.Password) return;
            if (!Birthday.Date.HasValue)
            {
                BirthdayLabel.Opacity = 1;
                return;
            }

            Member m = new Member(
                FirstName.Text,
                LastName.Text,
                Password.Password,
                Address.Text,
                Phone.Text,
                Avatar.Text,
                Int32.Parse(Gender.SelectedIndex.ToString()),
                Email.Text,
                Birthday.Date.Value.ToString("yyyy-MM-dd")
            );

            var contentJson = JsonConvert.SerializeObject(m);
            var response = new HttpClient().PostAsync(
                "https://2-dot-backup-server-002.appspot.com/_api/v2/members",
                new StringContent(contentJson, Encoding.UTF8, "application/json")
            ).Result;
            Debug.WriteLine(response.Content.ReadAsStringAsync().Result);
        }

        private void Check_empty(object sender, Windows.UI.Xaml.Input.KeyRoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            StackPanel parent = (StackPanel)textBox.Parent;
            parent.Children.OfType<TextBlock>().FirstOrDefault().Opacity = textBox.Text == "" ? 1 : 0;
        }

        private void Birthday_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {
            BirthdayLabel.Opacity = 0;
        }

        private void Confirm_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (Confirm.Password == "")
            {
                ConfirmLabel.Text = "*Field cannot be empty";
                ConfirmLabel.Opacity = 1;
            }
            else if (Confirm.Password != Password.Password)
            {
                ConfirmLabel.Text = "*Field does not match with password";
                ConfirmLabel.Opacity = 1;
            }
            else
            {
                ConfirmLabel.Opacity = 0;
            }
        }
    }
}
