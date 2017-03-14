namespace TeamInternational
{
    using StructureMap;
    using TeamInternational.Hierarchy;

    public class RegisterByContainer
    {
        public RegisterByContainer()
        {
            Container = new Container(x =>
            {
                x.For<IEngine>().Use<Engine>();
            });
        }


        public IContainer Container { get; set; }
    }
}
