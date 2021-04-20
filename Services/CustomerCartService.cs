using BookTalk.Data;
using BookTalk.Models;
using System.Collections.Generic;
using System.Linq;

public class CustomerCartService
{
    private static List<CheckoutSummary> cartItems = new List<CheckoutSummary>();

    private readonly Context _context;

    public CustomerCartService(Context context)
    {
        _context = context;

    }

    public List<CheckoutSummary> GetCheckoutSum()
    {
        return cartItems;
    }

    public void AddToCart(string bookId)
    {

        Book book = _context.Books.Where(x => x.Id.Equals(bookId)).FirstOrDefault();

        if (book is not null)
        {
            CheckoutSummary model = cartItems.Where(x => x.Book.Id.Equals(book.Id)).FirstOrDefault();

            if (model is not null)
            {
                model.Quantity++;
            }
            else
            {
                cartItems.Add(new CheckoutSummary(book, 1));
            }

        }

    }

    public void RemoveFromCart(string bookId)
    {

        CheckoutSummary itemToRemovew = cartItems.Where(x => x.Book.Id == bookId).FirstOrDefault();

        cartItems.Remove(itemToRemovew);
    }

    public  int GetCartCount()
    {
        return cartItems.Count;
    }

    public void DecrementItem(string bookid)
    {
        if (cartItems.Where(x => x.Book.Id.Equals(bookid)).FirstOrDefault().Quantity > 1)
        {
            cartItems.Where(x => x.Book.Id.Equals(bookid)).FirstOrDefault().Quantity--;
        }
        else
        {
            RemoveFromCart(bookid);
        }

        
    }


    public int GetQuantity(string bookid)
    {
        return cartItems.Where(x => x.Book.Id.Equals(bookid)).FirstOrDefault().Quantity;
    }
}
