--Q. On average, how many products are sold per order? 
SELECT AVG (ProdCount) FROM (SELECT Order_Id, COUNT(Product_Id) ProdCount FROM OrderItems 
GROUP BY Order_Id) SubQuery; 