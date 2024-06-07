namespace desafio_06._06._24.Models;

public class Ebook (double fileSize, string fileFormat, string title, string author, string isbn, string publicationYear) : Book(title, author, isbn, publicationYear)
{
    private string _title = title;
    private string _author = author;
    private string _isbn = isbn;
    private string _publicationYear = publicationYear;
    private double _fileSize = fileSize;
    private string _fileFormat = fileFormat;
    
    public override string DisplayDetails()
    {
        return $"{_title} {_author} {_isbn} {_publicationYear} {_fileSize} {_fileFormat}";
    }
}