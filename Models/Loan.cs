namespace desafio_06._06._24.Models;

public class Loan (User user, Book book, DateTime loanDate, DateTime returnDate)
{
    public User User { get; } = user;
    public Book Book { get; } = book;
    private DateTime _loanDate = loanDate;
    private DateTime _returnDate = returnDate;
    
    public string DisplayDetails() {
        return $"{User} {Book} {_loanDate} {_returnDate}";
    }

    public void Deconstruct(out Book book, out User user, out DateTime loanDate, out DateTime returnDate)
    {
        book = Book;
        user = User;
        loanDate = _loanDate;
        returnDate = _returnDate;
    }
}