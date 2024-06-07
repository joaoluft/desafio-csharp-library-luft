namespace desafio_06._06._24.Models;
using desafio_06._06._24.Interfaces;

public class Library : IBookManager
{
    private Dictionary<string, Book> _books = new();

    public void AddBook(Book book) {
      _books.Add(book.Isbn, book);
    }

    public void RemoveBook(string isbn) {
      _books.Remove(isbn);
    }

    public void ListBooks()
    {
      var books = _books.Values.ToList();
      foreach (var book in books)
      {
        Console.WriteLine(book.DisplayDetails());
      }
    }

    public Book FindBook(string isbn) {
      return _books[isbn];
    }
}