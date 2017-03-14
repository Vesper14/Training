namespace TeamInternational.Hierarchy
{
    using System;

    public class StartPageController
    {
        private StartPage page;


        public StartPageController(StartPage page)
        {
            this.page = page;
        }


        public void Index()
        {
            Console.WriteLine(this.page.Name);
        }
    }
}
