

SELECT Employees.Name, Employees.ManagerID, Employees.Salary,  
  CASE
    WHEN Managers.Name is Null  THEN Employees.Name
    ELSE Managers.Name
END as ManagerName
FROM  Employees 
			Left JOIN Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID