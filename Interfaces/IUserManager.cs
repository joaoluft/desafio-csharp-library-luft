namespace desafio_06._06._24.Interfaces;
using desafio_06._06._24.Models;

public interface IUserManager
{
    public void AddUser(User user);
    public void RemoveUser(int id);
    public void ListUsers();
    public User FindUser(int id);
}