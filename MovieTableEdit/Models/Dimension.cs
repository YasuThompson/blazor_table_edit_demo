using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTableEdit.Models;


public class TempProductDim
{   
    [Key]
    public required int ProductId { get; set; }
    public required string Title { get; set; }
    public required int ProductTypeId { get; set;}
    public required int GenreId { get; set;}
    public required string TitleDE { get; set; }
    public required string TitleFR { get; set; }
    public required string TitleES { get; set; }
    public required string TitleIT { get; set; }
    public required string TitleJP { get; set; }
    public required string Note {get; set;}
}

public class TempGenreDim
{
    [Key]
    public required int GenreId { get; set; }
    public required string Genre { get; set; }
    public string? Explanation { get; set; }
}

public class TempProductTypeDim
{
    [Key]
    public required int ProductTypeId { get; set; }
    public required string ProductType { get; set; }
}

public class TempRatingDEDim
{
    [Key]
    public required int RatingDEId { get; set; }
    public required string RatingDE { get; set; }
}

public class TempRatingFRDim
{
    [Key]
    public required int RatingFRId { get; set; }
    public required string RatingFR { get; set; }
}





public class ProductDim
{   
    public int Id { get; set;}
    public required int ProductId { get; set; }
    public required string Title { get; set; }
    public required int ProductTypeId { get; set;}
    public required int GenreId { get; set;}
    public required string TitleDE { get; set; }
    public required string TitleFR { get; set; }
    public required string TitleES { get; set; }
    public required string TitleIT { get; set; }
    public required string TitleJP { get; set; }
    public required string Note {get; set;}
}

public class GenreDim
{
    public int Id { get; set;}
    public required int GenreId { get; set; }
    public required string Genre { get; set; }
    public string? Explanation { get; set; }
}

public class ProductTypeDim
{
    public int Id { get; set;}
    public required int ProductTypeId { get; set; }
    public required string ProductType { get; set; }
}

public class RatingDEDim
{
    public int Id { get; set;}
    public required int RatingDEId { get; set; }
    public required string RatingDE { get; set; }
}

public class RatingFRDim
{
    public int Id { get; set;}
    public required int RatingFRId { get; set; }
    public required string RatingFR { get; set; }
}