
select Bodies.BodyName,VehicleDetails.*
from VehicleDetails
				inner join Bodies on VehicleDetails.BodyID = Bodies.BodyID
where (BodyName = 'Sport Utility') and (VehicleDetails.Year > 2020)