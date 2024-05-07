namespace BookInventoryWasm.Records
{
    public record BookRecord(int Id, string Title, string Author, string ISBN, string Genre, string ImageUrl);

    public class BookModel
    {
        public int Id { get; init; }
        public string Title { get; set; } // Change to have a public setter
        public string Author { get; set; } // Change to have a public setter
        public string ISBN { get; set; } // Change to have a public setter
        public string Genre { get; set; } // Change to have a public setter
        public string ImageUrl { get; set; } // Change to have a public setter

        // Constructor
        public BookModel(int id, string title, string author, string isbn, string genre, string imageUrl)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = isbn;
            Genre = genre;
            ImageUrl = imageUrl;
        }
    }

}