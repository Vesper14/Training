namespace TeamInternational.Hierarchy
{
    using System;

    public abstract class BasketWizardPageController<TPage> where TPage : Page, IWizardPage
    {
        private TPage page;

        private IEngine engine;


        public BasketWizardPageController(TPage page, IEngine engine)
        {
            this.page = page;
            this.engine = engine;
        }


        public void Index()
        {
            Console.WriteLine(this.page.WizardPageName);
            this.GoToNextPage();
        }

        public void GoToNextPage()
        {
            var nextPage = engine.Go(page);

            if (nextPage is FinalPage)
            {
                var controller = new FinalPageController(nextPage as FinalPage);
                controller.Index();
                return;
            }
            
        }
    }
}
