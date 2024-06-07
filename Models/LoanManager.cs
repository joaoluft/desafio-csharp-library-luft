namespace desafio_06._06._24.Models;
using desafio_06._06._24.Interfaces;

public class LoanManager : ILoanManager
{
    private List<Loan> _loans = new();

    public void RegisterLoan(Loan loan) {
      _loans.Add(loan);
    }

    public void RegisterReturn(string isbn, int userId)
    {
        var selectedLoan = FindLoan(isbn, userId);
        _loans.Remove(selectedLoan);
    }

    public void ListLoans()
    {
        foreach (var loan in _loans)
        {
            var (book, user, loanDate, returnDate) = loan;
            
            Console.WriteLine($"{book.DisplayDetails()} {user.DisplayDetails()} {loanDate} {returnDate}");
        }
    }

    public Loan FindLoan(string isbn, int userId)
    {
        return _loans.Find(loan => loan.User.Id.Equals(userId) && loan.Book.Isbn.Equals(isbn, StringComparison.OrdinalIgnoreCase));
    }
}