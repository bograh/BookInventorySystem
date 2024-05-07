var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var MyAllowSpecificOrigin = "_mySpecificOrigin";
builder.Services.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var Books = new List<BookRecord> {
    new BookRecord(1, "The Johnsons", "Mike Johnson", "9780068120084", "Biography"),
    new BookRecord(2, "To Kill a Mockingbird", "Harper Lee", "9780061120084", "Fiction"),
    new BookRecord(3, "1984", "George Orwell", "9780451524935", "Dystopian"),
    new BookRecord(4, "The Great Gatsby", "F. Scott Fitzgerald", "9780743273565", "Classics"),
    new BookRecord(5, "Harry Potter and the Sorcerer's Stone", "J.K. Rowling", "9780590353427", "Fantasy"),
    new BookRecord(6, "The Hobbit", "J.R.R. Tolkien", "9780547928227", "Fantasy"),
};

app.MapGet("/books", () =>
{
    return Books;
})
.WithName("GetBooks")
.WithOpenApi();

app.Run();

record Book