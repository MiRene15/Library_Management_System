namespace Library_Management_System.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }
        public List<Book> Books { get; set; } = new List<Book>(); // List of books written by the author
    }
}
