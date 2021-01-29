SELECT Products.ProductName  UrunAdi, 
SUM([Order Details].UnitPrice * [Order Details].Quantity) 
 KazanilanToplamTutar
FROM Products 
INNER JOIN [Order Details] on Products.ProductID = [Order Details].ProductID 
INNER JOIN Orders on Orders.OrderID = [Order Details].OrderID 
GROUP BY Products.ProductName 
ORDER BY ProductName, KazanilanToplamTutar