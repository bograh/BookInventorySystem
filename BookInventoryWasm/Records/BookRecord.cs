namespace BookInventoryWasm.Records
{
    public record BookRecord(int Id, string Title, string Author, string ISBN, string Genre, string ImageUrl, int Qty);

    public class BookModel
    {
        public int Id { get; init; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set; }
        public int Qty { get; set; }

        // Constructor
        public BookModel(int id, string title, string author, string isbn, string genre, string imageUrl, int qty)
        {
            Id = id;
            Title = title;
            Author = author;
            ISBN = isbn;
            Genre = genre;
            ImageUrl = imageUrl;
            Qty = qty;
        }
    }

}