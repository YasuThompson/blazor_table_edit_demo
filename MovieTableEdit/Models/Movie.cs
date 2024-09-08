using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTableEdit.Models;

public class MockMovieFact
{
    public int Id { get; set;}
    public int MovieId { get; set; }

    public DateOnly Date { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }
}


public class MockMovieFactFR
{
    public int Id { get; set;}
    public int MovieId { get; set; }

    public DateOnly Timestamp { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    public string? RatingFR {get; set; }
}

public class MockMovieFactDE
{
    public int Id { get; set;}
    public int MovieId { get; set; }

    public DateOnly Timestamp { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    public string? RatingDE {get; set; }

}

public class MockMovieDim
{   
    [Key]
    public int MovieId { get; set; }
    public string Title { get; set; }
    public int GenreId { get; set;}
    public string? TitleDE { get; set; }
    public string? TitleFR { get; set; }
    public string? TitleES { get; set; }
    public string? TitleIT { get; set; }
    public string? TitleJP { get; set; }

}

public class MockGenreDim
{
    [Key]
    public int GenreId { get; set; }
    public string Genre { get; set; }
}
