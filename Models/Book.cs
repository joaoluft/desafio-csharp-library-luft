namespace desafio_06._06._24.Models;

public class Book (string title, string author, string isbn, string publicationYear)
{
    private string _title = title;
    private string _author = author;
    private string _publicationYear = publicationYear;
    public string Isbn { get; } = isbn;

    public virtual string DisplayDetails()
    {
        return $"{_title} {_author} {Isbn} {_publicationYear}";
    }
}