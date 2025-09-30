

select 
(
	cast((select count(*) from VehicleDetails where NumDoors is null) as float)
	/
	cast((select count(*) from VehicleDetails) as float)
) as PercOfNoSpecDoors