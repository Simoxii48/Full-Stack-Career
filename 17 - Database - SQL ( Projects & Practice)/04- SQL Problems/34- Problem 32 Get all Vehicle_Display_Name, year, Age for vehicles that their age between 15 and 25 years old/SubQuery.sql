
select * from 
(
	select VehicleDetails.Vehicle_Display_Name,VehicleDetails.Year,
	Age = year(GetDate()) - VehicleDetails.Year
	from VehicleDetails
) R1 
where Age between 15 and 25;