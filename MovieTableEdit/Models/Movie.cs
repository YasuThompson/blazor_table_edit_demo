using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTableEdit.Models;

public class MockMovieFact
{
    [Key]
    public int Id { get; set; }

    public int MovieId { get; set; }

    public DateOnly Date { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}


public class MockMovieDim
{   
    [Key]
    public int MovieId { get; set; }
    public string Title { get; set; }
    public int? GenreId { get; set;}
}

public class MockGenreDim
{
    [Key]
    public int GenreId { get; set; }
    public string Genre { get; set; }
}
