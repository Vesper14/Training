namespace TeamInternational.Hierarchy
{
    using System;

    public class FinalPageController
    {
        private FinalPage page;


        public FinalPageController(FinalPage page)
        {
            this.page = page;
        }


        public void Index()
        {
            Console.WriteLine(this.page.Name);
        }
    }
}
