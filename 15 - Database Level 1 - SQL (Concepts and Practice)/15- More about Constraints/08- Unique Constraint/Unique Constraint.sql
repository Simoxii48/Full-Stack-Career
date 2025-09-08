
create table Persons (
ID int unique,
FisrtName varchar(255),
LastName varchar(255) not null,
Age int
);

create table Persons2 (
ID int not null,
FisrtName varchar(255),
LastName varchar(255) not null,
Age int,
constraint uc_person unique (ID, LastName)
);

alter table persons
add unique(ID);

alter table persons
add constraint uc_person unique (ID, LastName);

alter table persons
drop constraint uc_person;