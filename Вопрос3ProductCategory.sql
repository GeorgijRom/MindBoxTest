
SELECT P.ProductName, PC.CategoryName
FROM Products P
LEFT JOIN ProductCategory PC ON P.ProductId = PC.ProductId;