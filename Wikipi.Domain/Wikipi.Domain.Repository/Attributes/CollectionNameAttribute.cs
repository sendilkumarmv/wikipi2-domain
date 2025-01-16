namespace Wikipi.Domain.Repository.Attributes
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    public class CollectionNameAttribute : Attribute
    {
        private readonly string name;

        public CollectionNameAttribute(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }
}
