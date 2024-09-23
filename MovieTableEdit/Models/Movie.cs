using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTableEdit.Models;



public class MockProductPriceDE
{
    public int Id { get; set;}
    public int ProductId { get; set; }
    public int ProductTypeId {get; set;}
    public double Version { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    public int? RatingDEId {get; set; }
}

public class MockProductPriceFR
{
    public int Id { get; set;}
    public int ProductId { get; set; }
    public int ProductTypeId {get; set;}
    public double Version { get; set; }

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    public int? RatingFRId {get; set; }
}

public class MockProductDim
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

public class MockGenreDim
{
    [Key]
    public required int GenreId { get; set; }
    public required string Genre { get; set; }
    public string? Explanation { get; set; }
}

public class MockProductTypeDim
{
    [Key]
    public required int ProductTypeId { get; set; }
    public required string ProductType { get; set; }
}

public class MockRatingDEDim
{
    [Key]
    public required int RatingDEId { get; set; }
    public required string RatingDE { get; set; }
}

public class MockRatingFRDim
{
    [Key]
    public required int RatingFRId { get; set; }
    public required string RatingFR { get; set; }
}