namespace desafio_06._06._24.Interfaces;
using desafio_06._06._24.Models;

public interface ILoanManager
{
    public void RegisterLoan(Loan loan);
    public void RegisterReturn(string isbn, int userId);
    public void ListLoans();
    public Loan FindLoan(string isbn, int userId);
}