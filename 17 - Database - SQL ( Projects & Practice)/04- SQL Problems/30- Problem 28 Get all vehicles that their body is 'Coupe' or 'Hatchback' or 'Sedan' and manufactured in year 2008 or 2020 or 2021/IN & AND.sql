
select Bodies.BodyName, VehicleDetails.*
from VehicleDetails
				inner join Bodies on VehicleDetails.BodyID = Bodies.BodyID
where Bodies.BodyName in ('Coupe','Hatchback','Sedan') and year in (2008,2020,2021)