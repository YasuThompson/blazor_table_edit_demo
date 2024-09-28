using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTableEdit.Models;

public class TempProductPriceDE
{
    public int Id { get; set;}
    public int ProductId { get; set; }
    public int ProductTypeId {get; set;}

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    public int? RatingDEId {get; set; }
}

public class TempProductPriceFR
{
    public int Id { get; set;}
    public int ProductId { get; set; }
    public int ProductTypeId {get; set;}

    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Price { get; set; }

    public int? RatingFRId {get; set; }
}



public class ProductPriceDE
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

public class ProductPriceFR
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
