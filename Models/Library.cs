namespace Library_Management_System.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public List<Book> Books { get; set; } = new();
        public List<User> Users { get; set; } = new();
    }
}

