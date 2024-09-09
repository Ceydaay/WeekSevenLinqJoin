using WeekSevenLinqJoin;

var authors = new List<Author>
{
    new Author { AuthorId = 1, Name = "Orhan Pamuk" },
    new Author { AuthorId = 2, Name = "Elif Şafak" },
    new Author { AuthorId = 3, Name = "Ahmet Ümit" }
};

var books = new List<Book>
{
    new Book { BookId = 1, Title = "Kar", AuthorId = 1 },
    new Book { BookId = 2, Title = "İstanbul", AuthorId = 1 },
    new Book { BookId = 3, Title = "10 Minutes 38 Seconds in This Strange World", AuthorId = 2 },
    new Book { BookId = 4, Title = "Beyoğlu Rapsodisi", AuthorId = 3 }
};
var query = from book in books
            join author in authors on book.AuthorId equals author.AuthorId
            select new { book.Title, author.Name };

foreach (var result in query)
{
    Console.WriteLine($"Kitap: {result.Title}, Yazar: {result.Name}");
}

