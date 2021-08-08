use Goods
SELECT Products.Finishedgoods,Rawmaterials.Rawmaterials
FROM Products
INNER JOIN Rawmaterials ON Products.Finishedgoods = Rawmaterials.Finishedgoods;
select * from Products
