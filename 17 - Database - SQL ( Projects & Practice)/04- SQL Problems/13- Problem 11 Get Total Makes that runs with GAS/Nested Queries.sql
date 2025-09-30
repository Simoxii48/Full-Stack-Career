select count(*) as TotalMakesRunsOnGas
from
(
	select distinct Makes.Make, FuelTypes.FuelTypeName
	from VehicleDetails
		inner join Makes on VehicleDetails.MakeID = Makes.MakeID
		inner join FuelTypes on VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
	where FuelTypes.FuelTypeName = N'GAS'
) R1