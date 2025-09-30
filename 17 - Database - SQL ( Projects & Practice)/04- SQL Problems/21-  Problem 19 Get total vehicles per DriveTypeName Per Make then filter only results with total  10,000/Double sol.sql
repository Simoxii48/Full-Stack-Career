-- Using having
select distinct Makes.Make,DriveTypes.DriveTypeName,count(*) as Total
from VehicleDetails
				inner join Makes on VehicleDetails.MakeID = Makes.MakeID
				inner join DriveTypes on VehicleDetails.DriveTypeID = DriveTypes.DriveTypeID
group by Makes.Make, DriveTypes.DriveTypeName
having count(*) > 10000
order by Make asc, Total desc

-- Using where clause
select * from
(
select distinct Makes.Make,DriveTypes.DriveTypeName,count(*) as Total
from VehicleDetails
				inner join Makes on VehicleDetails.MakeID = Makes.MakeID
				inner join DriveTypes on VehicleDetails.DriveTypeID = DriveTypes.DriveTypeID
group by Makes.Make, DriveTypes.DriveTypeName
) R1
where R1.Total > 10000
order by R1.Make asc, R1.Total desc