namespace Test_3.Models
{
    public class PostData
    {
        public string Title { get; set; }
        public string Tag { get; set; }
        public string Content { get; set; }

        public PostData(string title, string tag, string content)
        {
            Title = title;
            Tag = tag;
            Content = content;
        }
    }
}