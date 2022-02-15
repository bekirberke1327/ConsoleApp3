--Select
SELECT ContactName Adi,City Sehir,CompanyName SirketAdi from Customers


SELECT* from Customers where City = 'Berlin'


SELECT * from Products where CategoryID=1 or CategoryID=3

SELECT * from Products where CategoryID=1 and UnitPrice>=10  

select * from Products order by UnitPrice desc        --ascending -> Artan --descending -> Azalan

SELECT * from Products where CategoryID=1 order by UnitPrice desc


select count(*) from Products where CategoryID=2


select CategoryID,count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID,Products.ProductName,Products.UnitPrice, Categories.CategoryName  from Products inner join Categories on Products.CategoryID=Categories.CategoryID where Products.UnitPrice>10


--DTO Data Transformation object


SELECT * from Products p left join [Order Details] od on p.ProductID = od.ProductID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null
