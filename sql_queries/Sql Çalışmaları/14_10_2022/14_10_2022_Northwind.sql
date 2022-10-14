select count(*) from Orders where CustomerID = 'VINET'

create view ProductWithCategory as 
select p.ProductID, p.ProductName, p.SupplierID, p.UnitPrice, p.UnitsInStock as Product,
ct.CategoryName, ct.Description as Category
from Products p inner join Categories ct on p.CategoryID = ct.CategoryID

drop view ProductWithCategory

create view ProductWithCategory as 
select p.ProductID, p.ProductName, p.SupplierID, p.UnitPrice, p.UnitsInStock as Product,
ct.CategoryName, ct.Description as Category
from Products p inner join Categories ct on p.CategoryID = ct.CategoryID

drop view ProductWithCategory

CREATE VIEW ProductWithCategory AS 
select p.ProductID, p.ProductName, p.SupplierID, s.CompanyName as Tedarikci, s.Phone, p.UnitPrice, 
p.UnitsInStock, ct.CategoryName, ct.Description
from Products p inner join Categories ct on p.CategoryID = ct.CategoryID
				inner join Suppliers s on s.SupplierID = p.SupplierID

select * from ProductWithCategory

create view OrderEmployee as
select o.OrderID, o.CustomerID, o.OrderDate, e.FirstName+' '+e.LastName as [Eleman]
from Employees e inner join Orders o on e.EmployeeID = o.EmployeeID
where OrderDate like '%1998%' and o.ShipCountry = 'USA'

select * from OrderEmployee