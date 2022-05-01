namespace LinkShortenerService.Models
{
    public class URLResponse
    {
        public Data data
        {
            get;
            set;
        }
        public int code
        {
            get;
            set;
        }
        public string[] errors
        {
            get;
            set;
        }
    }
}
