namespace Ativ5.Domain.Baskets
{
    using System.Collections.Generic;
    using System;
    using System.Collections.ObjectModel;

    public class AuthorCollection : Collection<Guid>
    {
        public AuthorCollection()
        {

        }

        public AuthorCollection(IEnumerable<Guid> list)
        {
            foreach (var item in list)
            {
                Items.Add(item);
            }
        }
    }
}
