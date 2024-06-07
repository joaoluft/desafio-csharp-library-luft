namespace desafio_06._06._24.Interfaces;
using desafio_06._06._24.Models;

public interface IBookManager
{
    public void AddBook(Book book);
    public void RemoveBook(string isbn);
    public void ListBooks();
    public Book FindBook(string isbn);
}