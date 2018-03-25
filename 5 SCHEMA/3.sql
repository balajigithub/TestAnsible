--Q. Which order was the largest in terms of the unit price? 
SELECT Order_Id, MAX (TotalUnitPrice) FROM 
(SELECT Order_Id, SUM(UnitPrice) TotalUnitPrice FROM OrderItems 
GROUP BY Order_Id) SubQuery 
GROUP BY Order_Id; 
