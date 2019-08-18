namespace Ativ5.WebApi.Utils
{
    using Ativ5.WebApi.Model;
    using System.Collections.Generic;
    using Ativ5.Application.Outputs;

    public class Utils
    {
        public static List<OrderDetailsModel> GetOrderDetailsModel(IReadOnlyList<OrderOutput> orders)
        {
            List<OrderDetailsModel> ordersModel = new List<OrderDetailsModel>();
            foreach (var item in orders)
            {
                var order = new OrderDetailsModel(
                    item.BasketId,
                    item.TotalPrice,
                    item.OrderDate
                );           
                ordersModel.Add(order);
            }
            return ordersModel;
        }
        public static List<BookDetailsModel> GetBookDetailsModel(IReadOnlyList<BookOutput> books)
        {
            List<BookDetailsModel> booksModel = new List<BookDetailsModel>();
            foreach(var bk in books)
            {                
                var book = new BookDetailsModel(
                    bk.BookId,
                    bk.Price,
                    bk.ISBN,                    
                    bk.Title,
                    GetAuthorDetailsModel(bk.Authors)
                );
                booksModel.Add(book);
            }
            return booksModel;
        }

        public static List<AuthorDetailsModel> GetAuthorDetailsModel(IReadOnlyList<AuthorOutput> authors)
        {
            List<AuthorDetailsModel> authorsModel = new List<AuthorDetailsModel>();
            foreach (var author in authors)
            {
                var auth = new AuthorDetailsModel(
                    author.AuthorId,
                    author.Name
                );
                authorsModel.Add(auth);
            }
            return authorsModel;
        }

    }
}