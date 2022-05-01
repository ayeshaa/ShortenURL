namespace LinkShortenerService.Models
{
    public class Data
    {
        public string domain
        {
            get;
            set;
        }
        public string alias
        {
            get;
            set;
        }
        public bool deleted
        {
            get;
            set;
        }
        public bool archived
        {
            get;
            set;
        }
        public string[] tags
        {
            get;
            set;
        }
        public string created_at
        {
            get;
            set;
        }
        public string expires_at
        {
            get;
            set;
        }
        public string tiny_url
        {
            get;
            set;
        }
        public string url
        {
            get;
            set;
        }
        public Analytics analytics
        {
            get;
            set;
        }
    }
}
