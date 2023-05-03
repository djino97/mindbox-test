SELECT 
	p.Name AS "ProductName",
	c.Name AS "CategoryName"
FROM Products AS p 
	LEFT JOIN ProductsCategories AS pc 
		ON p.ID = pc.ProductID
	LEFT JOIN Categories AS c
		ON c.ID = pc.CategoryID
