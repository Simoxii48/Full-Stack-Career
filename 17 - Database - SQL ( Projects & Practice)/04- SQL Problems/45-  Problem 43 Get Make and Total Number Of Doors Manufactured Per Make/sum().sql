
select Makes.Make, sum(VehicleDetails.NumDoors) as TotalNumOfDoors
from VehicleDetails
				inner join Makes on VehicleDetails.MakeID = Makes.MakeID
group by Makes.Make
order by TotalNumOfDoors desc