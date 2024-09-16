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

    public int? RatingDE {get; set; }
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

    public int? RatingFR {get; set; }
}

public class MockProductDim
{   
    [Key]
    public int ProductId { get; set; }
    public string Title { get; set; }
    public int ProductTypeId { get; set;}
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

public class MockProductTypeDim
{
    [Key]
    public int ProductTypeId { get; set; }
    public string ProductType { get; set; }
}

public class MockRatingDEDim
{
    [Key]
    public int RatingDEId { get; set; }
    public string RatingDE { get; set; }
}

public class MockRatingFRDim
{
    [Key]
    public int RatingFRId { get; set; }
    public string RatingFR { get; set; }
}