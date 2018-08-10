using System.Linq;

namespace Exam.Pages.AutomateThePlanetPage
{
   public partial class BlogSectionPage : DefaultPage
    {
        public BlogSectionPage( ) : base("blog")
        {
        }

        public void OpenBlog(int position)
        {
            Blogs.ElementAt(position).Click();
        }
    }
}