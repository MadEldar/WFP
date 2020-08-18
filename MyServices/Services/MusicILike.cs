using Newtonsoft.Json;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using MyServices.Entities;

namespace MyServices.Services
{
    public class MusicILike
    {
        private static string BaseURI = "https://2-dot-backup-server-002.appspot.com/";
        private static string SignUpURI = BaseURI + "_api/v2/members";
        private static string SignInURI = BaseURI + "_api/v2/members/authentication";
        private static string CreateSongURI = BaseURI + "_api/v2/songs";
        private static string GetProfileURI = BaseURI + "_api/v2/members/information";
        private static string UploadTokenURI = BaseURI + "get-upload-token";

        private static string Token = "";
        private const string MediaType = "application/json";

        public static string GetToken() { return Token; }

        public async static void SignUp(Member m)
        {
            var contentJson = JsonConvert.SerializeObject(m);
            var response = await new HttpClient().PostAsync(SignUpURI, new StringContent(contentJson, Encoding.UTF8, MediaType));
            if (response.StatusCode == HttpStatusCode.Created)
            {
                Debug.WriteLine("Created member successfully");
            }
            else
            {
                Debug.WriteLine("Failed");
            }
        }

        public async static Task<ResponseResult> SignIn(string content)
        {
            var response = await new HttpClient().PostAsync(SignInURI, new StringContent(content, Encoding.UTF8, MediaType));
            var result = JsonConvert.DeserializeObject<ResponseResult>(await response.Content.ReadAsStringAsync());
            if (result.status == 1)
            {
                Token = result.token;
            }
            return result;
        }

        public async static Task<ResponseResult> CreateSong(string content)
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + Token);
            var response = await httpClient.PostAsync(CreateSongURI, new StringContent(content, Encoding.UTF8, MediaType));
            return JsonConvert.DeserializeObject<ResponseResult>(await response.Content.ReadAsStringAsync());
        }

        public async static Task<string> GetUploadToken()
        {
            var response = await new HttpClient().GetAsync(UploadTokenURI);
            if (response.StatusCode != HttpStatusCode.OK)
            {
                Debug.WriteLine("Cannot get upload token");
                return null;
            }
            return await response.Content.ReadAsStringAsync();
        }

        public async static Task<string> GetProfile()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", "Basic " + Token);
            var response = await httpClient.GetAsync(GetProfileURI);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
