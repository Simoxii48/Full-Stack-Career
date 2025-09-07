select id,firstname,lastname,GendorTitle = 
case 
	when Gendor = 'M' then 'Male'
	when Gendor = 'F' then 'Female'
	else 'Unknown'
end
from employees;

select id,firstname,lastname,GendorTitle = 
case 
	when Gendor = 'M' then 'Male'
	when Gendor = 'F' then 'Female'
	else 'Unknown'
end,
Status = 
case
	when ExitDate is null then 'Active'
	when ExitDate is not null then 'Resigned'
end
from employees;

select id,firstname,lastname,monthlysalary,
newSalarytobe = 
case
	when gendor = 'M' then monthlysalary * 1.1
	when gendor = 'F' then monthlysalary * 1.15
end
from employees;