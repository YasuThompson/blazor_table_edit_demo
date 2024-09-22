WITH selected_price AS (
    SELECT 
        * 
    FROM MockProductPriceDE 
    WHERE ProductTypeId=1 AND Version=(SELECT MAX(Version) FROM MockProductPriceDE WHERE ProductTypeId=1)
    UNION
    SELECT 
        * 
    FROM MockProductPriceDE 
    WHERE ProductTypeId=2 AND Version=(SELECT MAX(Version) FROM MockProductPriceDE WHERE ProductTypeId=2)
    UNION
    SELECT 
        * 
    FROM MockProductPriceDE 
    WHERE ProductTypeId=3 AND Version=(SELECT MAX(Version) FROM MockProductPriceDE WHERE ProductTypeId=3)
    UNION
    SELECT 
        * 
    FROM MockProductPriceDE 
    WHERE ProductTypeId=4 AND Version=(SELECT MAX(Version) FROM MockProductPriceDE WHERE ProductTypeId=4)
)
SELECT 
    product.ProductId, 
    selected_price.Price
FROM MockProductDim product
LEFT JOIN selected_price ON product.ProductId=selected_price.ProductId