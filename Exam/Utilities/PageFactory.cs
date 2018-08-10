using Exam.Pages;

namespace Exam.Utilities
{
    public static class PageFactory
    {
        public static T Get<T>() where T : DefaultPage, new()
        {
            T page = new T();
            return page;
        }
    }
}