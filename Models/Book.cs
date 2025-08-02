namespace Library_Management_System.Models
{
    public class Book
    {
        public Author Author { get; set; }
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public string ISBN { get; set; }
        public int PublicationYear { get; set; }
        public bool IsAvailable { get; set; } = true;
        public DateTime? DateReturned { get; set; }
    }

    public enum Genre
    {
        Kids,
        Scifi,
        Horror,
        Fanfiction,
        Educational,
        Romance,
        ShortStory

    }
}
