-- index will help optimize data retrieval from database
create table Persons (
ID int primary key, -- primary key is an automatic clustered index
FisrtName varchar(255),
LastName varchar(255) not null,
Age int
);

create index idx_lastname
on persons (lastname); -- will create a hidden table organized asc auto with the column lastname

drop index persons.idx_lastname;

create index idx_pname
on persons (lastname, fisrtname);

drop index persons.idx_pname;