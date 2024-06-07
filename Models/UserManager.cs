namespace desafio_06._06._24.Models;
using desafio_06._06._24.Interfaces;

public class UserManager : IUserManager
{
    private Dictionary<int, User> _users = new();
    
    public void AddUser(User user) {
      _users.Add(user.Id, user);
    }

    public void RemoveUser(int id) {
      _users.Remove(id);
    }

    public void ListUsers() {
      var users = _users.Values.ToList();
      foreach (var user in users)
      {
        System.Console.WriteLine(user.DisplayDetails());
      }
    }

    public User FindUser(int id)
    {
      return _users[id];
    }
}