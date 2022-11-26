select * from Employees

select AVG(DATEDIFF(year,BirthDate,GETDATE()))from Employees 


select productname,unitprice as 
KDVharic,(unitprice*0.18+UnitPrice) 
as KDVDAHİL from Products 

select productname,(UnitPrice*0.18) as KDVucreti from Products where (UnitPrice*0.18)<10


select * from Products where UnitsInStock=0