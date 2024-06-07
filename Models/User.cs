namespace desafio_06._06._24.Models;

public class User(string name, string email, int id)
{
    private string _name = name;
    private string _email = email;
    public int Id { get; } = id;
    public virtual string DisplayDetails() {
      return $"{_name} {_email} {Id}";
    }
}