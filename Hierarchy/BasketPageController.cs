namespace TeamInternational.Hierarchy
{
    using System;

    public class BasketPageController : BasketWizardPageController<BasketPage>//
    {
        //private BasketPage page;


        public BasketPageController(BasketPage page, IEngine engine) : base(page, engine)//
        {
            //this.page = page;
        }


        //public void Index()
        //{
        //    Console.WriteLine(this.page.Name);
        //}

        //public void GoToNextPage()
        //{

        //}
    }
}
