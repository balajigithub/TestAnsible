--Question. What is the total price of all orders? 
SELECT Order_Id, SUM (TotalPrice) FROM OrderItems GROUP BY Order_Id; 