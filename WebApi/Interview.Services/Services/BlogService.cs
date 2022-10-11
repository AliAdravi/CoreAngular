namespace Interview.Services.Services
{
    public class BlogService : IBlogService
    {
        public BloggingContext _blogingContx;

        public BlogService()
        {
            this._blogingContx = new BloggingContext();
        }

        public List<Blog> GetBlogs()
        {
            return _blogingContx.Blogs.ToList();
        }
    }
}