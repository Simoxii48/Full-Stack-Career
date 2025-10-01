
select Employees.Name, Employees.ManagerID,Employees.Salary, 
Managers.Name as ManagerName
from Employees
			left join Employees as Managers on Employees.ManagerID = Managers.EmployeeID