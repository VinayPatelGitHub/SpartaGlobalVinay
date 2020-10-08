SELECT CategoryID as 'categProds'
, AVG(UnitPrice) as 'AvgPrice'
FROM Products
GROUP BY CategoryID
