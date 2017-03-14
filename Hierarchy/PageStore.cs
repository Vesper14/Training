namespace TeamInternational.Hierarchy
{
    using System.Collections.Generic;

    public sealed class PageStore
    {
        private static readonly PageStore instance = new PageStore();

        private IEnumerable<Page> pages;


        static PageStore() { }

        private PageStore()
        {
            this.pages = new List<Page>
            {
                new StartPage { Name = "StartPage"},
                new BasketPage { Name = "BasketPage", WizardPageName = "Basket" },
                new FinalPage { Name = "SuccessPage", WizardPageName = "Success" },
                new FinalPage { Name = "FailPage", WizardPageName = "Fail" }
            };
        }


        public static IEnumerable<Page> Pages
        {
            get
            {
                return instance.pages;
            }
        }
    }
}
