
select distinct Makes.MakeID, Makes.Make,SubModels.SubModelName
from VehicleDetails
				inner join SubModels on VehicleDetails.SubModelID = SubModels.SubModelID
				inner join Makes on VehicleDetails.MakeID = Makes.MakeID
where SubModels.SubModelName = 'Elite'
order by Make