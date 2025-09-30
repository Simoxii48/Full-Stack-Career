
-- First method is to pass result data as a table to another query
select * from 
(
	select Makes.Make, count(*) as NumberOfVehicules
	from VehicleDetails
		inner join Makes on VehicleDetails.MakeID = Makes.MakeID
	group by Makes.Make
) R1 
where NumberOfVehicules > 20000
order by NumberOfVehicules desc;

-- Second method using having
select Makes.Make, count(*) as NumberOfVehicules
	from VehicleDetails
		inner join Makes on VehicleDetails.MakeID = Makes.MakeID
	group by Makes.Make
	having count(*) > 20000
	order by NumberOfVehicules desc;