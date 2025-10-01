
select makes.make, sum(VehicleDetails.NumDoors) as TotalNumOfDoors
from VehicleDetails
					inner join makes on VehicleDetails.MakeID = Makes.MakeID
group by make
having make='Ford'