select * from activeEmployees;

select * from resignedEmployees;

select * from activeEmployees
union
select * from resignedEmployees;

-- union will not merge duplicated data 
select * from Departments
union 
select * from Departments;

-- using union all will allow duplication
select * from Departments
union all
select * from Departments;