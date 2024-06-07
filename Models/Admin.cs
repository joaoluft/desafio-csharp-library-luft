namespace desafio_06._06._24.Models;

public class Admin(int accessLevel, string name, string email, int id) : User(name, email, id)
{
  private int _accessLevel = accessLevel;
  private string _name = name;
  private string _email = email;
  private int _id = id;
  
  public override string DisplayDetails()
  {
    return $"{_accessLevel} {_name} {_email} {_id}";
  }
}