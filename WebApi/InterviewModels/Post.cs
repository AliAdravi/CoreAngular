namespace InterviewModels
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; } = String.Empty;
        public string Content { get; set; } = String.Empty;

        public int BlogId { get; set; }
        public Blog? Blog { get; set; }
    }
}