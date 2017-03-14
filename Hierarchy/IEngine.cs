namespace TeamInternational.Hierarchy
{
    public interface IEngine
    {
        Page Go<TPage>(TPage page) where TPage : Page, IWizardPage;
    }
}
