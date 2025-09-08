
create table Persons (
ID int not null,
FisrtName varchar(255),
LastName varchar(255) not null,
Age int,
City varchar(255) default 'Amman'
);

create table Orders (
ID int not null,
OrderNumber int not null,
OrderDate date default getdate()
);

-- To add the default constraint if not added within table creation
alter table persons
add constraint df_City
default 'Amman' for city;

alter table persons
drop constraint df_city;