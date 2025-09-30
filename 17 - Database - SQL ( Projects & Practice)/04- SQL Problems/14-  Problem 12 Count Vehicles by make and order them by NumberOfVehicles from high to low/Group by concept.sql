
select distinct Makes.Make,count(*) as NumberOfVehicules
from VehicleDetails 
		inner join Makes on VehicleDetails.MakeID = Makes.MakeID
group by Makes.Make
order by NumberOfVehicules desc