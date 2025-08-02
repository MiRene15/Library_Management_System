using Library_Management_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library_Management_System.Controllers
{
    public class LibraryController : Controller
    {
        private static Library library = new Library();

        static LibraryController()
        {
            var author1 = new Author { Id = 1, Name = "Jose Rizal" };
            var author2 = new Author { Id = 2, Name = "Nick Joaquin" };
            var author3 = new Author { Id = 3, Name = "Edgar Allan Poe" };  
            var author4 = new Author { Id = 4, Name = "J.K. Rowling" };
            var author5 = new Author { Id = 5, Name = "Stephen King" }; 
            var author6 = new Author { Id = 6, Name = "L. Frank Baum" };
            var author7 = new Author { Id = 7, Name = "J.R.R. Tolkien" };
            var author8 = new Author { Id = 8, Name = "George Orwell" };
            var author9 = new Author { Id = 9, Name = "Agatha Christie" };
            var author10 = new Author { Id = 10, Name = "Mark Twain" };

            var book1 = new Book
            {
                Author = author1,
                Title = "Noli Me Tangere",
                Genre = Genre.Educational,
                ISBN = "978-971-10-1000-1",
                PublicationYear = 1887,
                DateReturned = DateTime.Now.AddDays(-7),
                IsAvailable = false
            };

            var book2 = new Book
            {
                Author = author2,
                Title = "May Day Eve",
                Genre = Genre.ShortStory,
                ISBN = "978-971-10-1000-2",
                PublicationYear = 1990,
                DateReturned = DateTime.Now.AddDays(-3),
                IsAvailable = true
            };

            var book3 = new Book
            {
                Author = author3,
                Title = "The Raven",
                Genre = Genre.Horror,
                ISBN = "978-971-10-1000-3",
                PublicationYear = 1845,
                DateReturned = DateTime.Now.AddDays(-1),
                IsAvailable = true
            };

            var book4 = new Book
            {
                Author = author4,
                Title = "Harry Potter and the Philosopher's Stone",
                Genre = Genre.Fanfiction,
                ISBN = "978-971-10-1000-4",
                PublicationYear = 1997,
                DateReturned = DateTime.Now.AddDays(5),
                IsAvailable = true
            };

            var book5 = new Book
            {
                Author = author5,
                Title = "The Shining",
                Genre = Genre.Horror,
                ISBN = "978-971-10-1000-5",
                PublicationYear = 1977,
                DateReturned = DateTime.Now.AddDays(10),
                IsAvailable = true
            };

            var book6 = new Book
            {
                Author = author6,
                Title = "The Wonderful Wizard of Oz",
                Genre = Genre.Kids,
                ISBN = "978-971-10-1000-6",
                PublicationYear = 1900,
                DateReturned = DateTime.Now.AddDays(2),
                IsAvailable = true
            };

            var book7 = new Book
            {
                Author = author7,
                Title = "The Hobbit",
                Genre = Genre.Fanfiction,
                ISBN = "978-971-10-1000-7",
                PublicationYear = 1937,
                DateReturned = DateTime.Now.AddDays(3),
                IsAvailable = true
            };

            var book8 = new Book
            {
                Author = author8,
                Title = "1984",
                Genre = Genre.Scifi,
                ISBN = "978-971-10-1000-8",
                PublicationYear = 1949,
                DateReturned = DateTime.Now.AddDays(1),
                IsAvailable = true
            };

            var book9 = new Book
            {
                Author = author9,
                Title = "And Then There Were None",
                Genre = Genre.Horror,
                ISBN = "978-971-10-1000-9",
                PublicationYear = 1939,
                DateReturned = DateTime.Now.AddDays(4),
                IsAvailable = true
            };

            var book10 = new Book
            {
                Author = author10,
                Title = "The Adventures of Tom Sawyer",
                Genre = Genre.Kids,
                ISBN = "978-971-10-1000-10",
                PublicationYear = 1876,
                DateReturned = DateTime.Now.AddDays(6),
                IsAvailable = true
            };


            var user1 = new User { Id = 1, FullName = "Juan Dela Cruz" };
            var user2 = new User { Id = 2, FullName = "Maria Clara" };
            var user3 = new User { Id = 3, FullName = "Jose Rizal" };
            var user4 = new User { Id = 4, FullName = "Andres Bonifacio" };
            var user5 = new User { Id = 5, FullName = "Emilio Aguinaldo" };
            var user6 = new User { Id = 6, FullName = "Andres Bonifacio" };
            var user7 = new User { Id = 7, FullName = "Emilio Jacinto" };
            var user8 = new User { Id = 8, FullName = "Apolinario Mabini" };
            var user9 = new User { Id = 9, FullName = "Gregoria de Jesus" };
            var user10 = new User { Id = 10, FullName = "Jose Palma" };

            user1.BorrowedBooks.Add(book1);
            user2.BorrowedBooks.Add(book2);
            user3.BorrowedBooks.Add(book3);
            user4.BorrowedBooks.Add(book4);
            user5.BorrowedBooks.Add(book5);
            user6.BorrowedBooks.Add(book6);
            user7.BorrowedBooks.Add(book7);
            user8.BorrowedBooks.Add(book8);
            user9.BorrowedBooks.Add(book9);
            user10.BorrowedBooks.Add(book10);

            library.Books.Add(book1);
            library.Books.Add(book2);
            library.Books.Add(book3);
            library.Books.Add(book4);
            library.Books.Add(book5);
            library.Books.Add(book6);
            library.Books.Add(book7);
            library.Books.Add(book8);
            library.Books.Add(book9);
            library.Books.Add(book10);


            library.Users.Add(user1);
            library.Users.Add(user2);
            library.Users.Add(user3);
            library.Users.Add(user4);
            library.Users.Add(user5);   
            library.Users.Add(user6);
            library.Users.Add(user7);
            library.Users.Add(user8);
            library.Users.Add(user9);
            library.Users.Add(user10);
        }



        public IActionResult Books()
        {
            return View(library.Books);
        }

        public IActionResult Users()
        {
            return View(library.Users);
        }
 
        
    }
}

