namespace Library_Management_System.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // e.g., "Admin", "Member"
        public DateTime DateRegistered { get; set; }
        public bool IsActive { get; set; } // Indicates if the user account is active
        public List<Book> BorrowedBooks { get; set; } = new List<Book>(); // Index currently borrowed by the user
    }
}