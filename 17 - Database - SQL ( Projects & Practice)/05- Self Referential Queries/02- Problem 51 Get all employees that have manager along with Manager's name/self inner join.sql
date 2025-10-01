
select Employees.Name,Employees.ManagerID,Employees.Salary,Managers.Name as ManagerName
from Employees 
	inner join Employees as Managers on Employees.ManagerID = Managers.EmployeeID