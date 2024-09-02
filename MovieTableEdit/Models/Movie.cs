using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorWebAppMovies.Models;

public class MockMovieFact
{
    public int Id { get; set; }

    public int MovieId { get; set; }

    public DateOnly Date { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}


public class MockMovieDim
{
    public int MovieId { get; set; }
    public string Title { get; set; }
    public int? GenreId { get; set;}
}

public class MockGenreDim
{
    public int GenreId { get; set; }
    public string Genre { get; set; }
}
