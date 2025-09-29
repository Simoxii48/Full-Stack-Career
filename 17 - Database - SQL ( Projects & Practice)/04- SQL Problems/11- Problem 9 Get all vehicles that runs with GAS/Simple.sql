
select VehicleDetails.*, FuelTypes.FuelTypeName
from VehicleDetails
		inner join FuelTypes on VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
where (FuelTypes.FuelTypeName = N'GAS')