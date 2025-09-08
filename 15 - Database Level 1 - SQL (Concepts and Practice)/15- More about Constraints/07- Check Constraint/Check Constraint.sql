
create table Persons (
ID int not null,
FisrtName varchar(255),
LastName varchar(255) not null,
Age int check (age <= 18)
);

create table Persons2 (
ID int not null,
FisrtName varchar(255),
LastName varchar(255) not null,
Age int,
City varchar(255),
constraint chk_person check (age >= 18 and city = 'Amman')
);

alter table persons2
drop constraint chk_person