
-- View is a result table that we mostly use it a lot so we save as a view to be accessed faster than writing the query every time
create view ActiveEmployees as
select * from employees 
where exitDate is null;

-- it's like a table now we can operate what we want 
select * from ActiveEmployees
where id=285;

create view ResignedEmployees as 
select * from Employees
where ExitDate is not null;

select * from employees;

-- in case we want to grant access to someone this view will allow him to access only the following data
create view ShortDetailEmployees as
select id, firstname, lastname, gendor
from employees;

select * from ShortDetailEmployees;