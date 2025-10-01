
select distinct Makes.Make from VehicleDetails
				inner join Makes on VehicleDetails.MakeID = Makes.MakeID
where VehicleDetails.Engine_CC in
(
	select top 3 Engine_CC from VehicleDetails
	order by Engine_CC desc
)