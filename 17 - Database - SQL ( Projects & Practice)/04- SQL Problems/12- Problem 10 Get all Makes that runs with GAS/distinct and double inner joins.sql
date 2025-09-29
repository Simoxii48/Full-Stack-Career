
select distinct Makes.Make, FuelTypes.FuelTypeName
from VehicleDetails 
				inner join FuelTypes on VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
				inner join Makes on VehicleDetails.MakeID = Makes.MakeID
where FuelTypes.FuelTypeName = N'GAS'