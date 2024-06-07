using desafio_06._06._24.Models;

// Teste das classes e métodos
// Criando uma biblioteca
Library library = new();

// Adicionando livros
Book book1 = new(title: "The Lord of the Rings", author: "J.R.R. Tolkien", isbn: "9780544003415", publicationYear: "1954");
Ebook ebook1 = new(title: "Harry Potter and the Philosopher's Stone", author: "J.K. Rowling", isbn: "9781408855652", publicationYear: "1997", fileSize: 144.5, fileFormat: "PDF" );

library.AddBook(book1);
library.AddBook(ebook1);

// Listando livros na biblioteca
Console.WriteLine("Livros na biblioteca:");
library.ListBooks();
Console.WriteLine();

// Criando um usuário
User user1 = new(name: "John Doe", email: "john@example.com", id: 123);

// Criando um administrador
Admin admin1 = new(name: "Jane Smith", email: "jane@example.com", id: 456, accessLevel: 5);

// Criando um gerenciador de usuários
UserManager userManager = new();
userManager.AddUser(user1);
userManager.AddUser(admin1);

// Listando usuários
Console.WriteLine("Usuários no sistema:");
userManager.ListUsers();
Console.WriteLine();

// Realizando um empréstimo
LoanManager loanManager = new();
loanManager.RegisterLoan(new Loan(user: user1, book: book1,  loanDate: DateTime.Now, returnDate: DateTime.Now.AddDays(14)));

// Listando empréstimos
Console.WriteLine("Empréstimos no sistema:");
loanManager.ListLoans();
Console.WriteLine();