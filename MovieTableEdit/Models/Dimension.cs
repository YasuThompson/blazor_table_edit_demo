using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieTableEdit.Models;


public class TempProductDim
{   
    [Key]
    public int ProductId { get; set; }
    public string Title { get; set; }
    public int ProductTypeId { get; set;}
    public int GenreId { get; set;}
    public string TitleDE { get; set; }
    public string TitleFR { get; set; }
    public string TitleES { get; set; }
    public string TitleIT { get; set; }
    public string TitleJP { get; set; }
    public string Note {get; set;}
    public bool Active {get; set;}
}

public class TempGenreDim
{
    [Key]
    public int GenreId { get; set; }
    public string Genre { get; set; }
    public string? Explanation { get; set; }
    public bool Available {get; set;}
}

public class TempProductTypeDim
{
    [Key]
    public int ProductTypeId { get; set; }
    public string ProductType { get; set; }
}

public class TempRatingDEDim
{
    [Key]
    public int RatingDEId { get; set; }
    public string RatingDE { get; set; }
}

public class TempRatingFRDim
{
    [Key]
    public int RatingFRId { get; set; }
    public string RatingFR { get; set; }
}





public class ProductDim
{   
    public int Id { get; set;}
    public int ProductId { get; set; }
    public string Title { get; set; }
    public int ProductTypeId { get; set;}
    public int GenreId { get; set;}
    public string TitleDE { get; set; }
    public string TitleFR { get; set; }
    public string TitleES { get; set; }
    public string TitleIT { get; set; }
    public string TitleJP { get; set; }
    public string Note {get; set;}
    public double Version { get; set; }
}

public class GenreDim
{
    public int Id { get; set;}
    public int GenreId { get; set; }
    public string Genre { get; set; }
    public string? Explanation { get; set; }
    public double Version { get; set; }
}

public class ProductTypeDim
{
    public int Id { get; set;}
    public int ProductTypeId { get; set; }
    public string ProductType { get; set; }
    public double Version { get; set; }
}

public class RatingDEDim
{
    public int Id { get; set;}
    public int RatingDEId { get; set; }
    public string RatingDE { get; set; }
    public double Version { get; set; }
}

public class RatingFRDim
{
    public int Id { get; set;}
    public int RatingFRId { get; set; }
    public string RatingFR { get; set; }
    public double Version { get; set; }
}