

select Makes.Make as Make, count(*) as NumberOfVehicules, (select count(*) from VehicleDetails) as TotalVehicules
from VehicleDetails inner join Makes on VehicleDetails.MakeID = Makes.MakeID
where VehicleDetails.Year between 1950 and 2000
group by Makes.Make
order by NumberOfVehicules desc