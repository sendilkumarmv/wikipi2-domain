using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wikipi.Domain.Repository.Attributes
{
    public static class TypeExtensions
    {
        public static string GetCollectionName(this Type definition)
        {
            var attribute = definition.UnderlyingSystemType.GetCustomAttributes(typeof(CollectionNameAttribute), true).FirstOrDefault();

            if (attribute != null)
                return ((CollectionNameAttribute)attribute).GetName();
            else
                return definition.Name.ToLower();
        }
    }
}
