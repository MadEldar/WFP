
namespace MyServices.Entities
{
    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string password { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string avatar { get; set; }
        public int gender { get; set; }
        public string email { get; set; }
        public string birthday { get; set; }

        public Member()
        {
        }

        public Member(string firstName, string lastName, string password, string address, string phone, string avatar, int gender, string email, string birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.address = address;
            this.phone = phone;
            this.avatar = avatar;
            this.gender = gender;
            this.email = email;
            this.birthday = birthday;
        }
    }

    public class MemberViewModel
    {
        private Member _member = new Member();
        public Member _MemberViewModel { get => _member; }
    }
}
