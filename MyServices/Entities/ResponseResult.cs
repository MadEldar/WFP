namespace MyServices.Entities
{
    public class ResponseResult
    {
        public string token { get; set; }
        public string secret { get; set; }
        public long userId { get; set; }
        public long createdTimeMLS { get; set; }
        public long expiredTimeMLS { get; set; }
        public int status { get; set; }
    }
}