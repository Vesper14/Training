namespace TeamInternational.Hierarchy
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine : IEngine
    {
        private static IDictionary<string, Page> BasketFlow = new Dictionary<string, Page>();

        private static IDictionary<string, Page> RegisterFlow = new Dictionary<string, Page>();

        private static Random Random = new Random();


        static Engine()
        {
            BasketFlow.Add("Basket", GetPage(typeof(BasketPage), "Basket"));
            BasketFlow.Add("SuccessPayment", GetPage(typeof(FinalPage), "Success"));
            BasketFlow.Add("FailPayment", GetPage(typeof(FinalPage), "Fail"));
        }


        private static Page GetPage(Type pageType, string wizardPageName)
        {
            foreach (var page in PageStore.Pages)
            {
                var wizardPage = page as IWizardPage;

                if (wizardPage != null && page.GetType() == pageType && wizardPage.WizardPageName == wizardPageName)
                {
                    return page;
                }
            }

            return null;
        }

        public Page Go<TPage>(TPage page) where TPage : Page, IWizardPage
        {
            var startPage = PageStore.Pages.OfType<StartPage>().SingleOrDefault();

            if (BasketFlow.ContainsKey(page.WizardPageName))
            {
                if (page.WizardPageName == "Basket")
                {
                    return (Random.Next(2) == 0)
                        ? BasketFlow["SuccessPayment"]
                        : BasketFlow["FailPayment"];
                }
            }

            return startPage;
        }
    }
}
