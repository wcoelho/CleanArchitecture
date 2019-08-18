namespace Ativ5.Domain.Baskets
{
    using Ativ5.Domain.ValueObjects;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;


    public class BookCollection : Collection<Book>
    {
        public BookCollection()
        {

        }

        public BookCollection(IEnumerable<Book> list)
        {
            foreach (var item in list)
            {
                Items.Add(item);
            }
        }
    
        public FinalPrice GetTotalPrice()
        {
            FinalPrice totalAmount = 0;

            foreach (var item in Items)
            {
                totalAmount+= item.Price;
            }

            return totalAmount;
        }
    }
}
