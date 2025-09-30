
select VehicleDetails.Vehicle_Display_Name, VehicleDetails.NumDoors,
case
	when NumDoors = 0 then 'Zero Doors'
	when NumDoors = 1 then 'One Door'
	when NumDoors = 2 then 'Two Doors'
	when NumDoors = 3 then 'Three Doors'
	when NumDoors = 4 then 'Foor Doors'
	when NumDoors = 5 then 'Five Doors'
	when NumDoors = 6 then 'Six Doors'
	when NumDoors = 8 then 'Eight Doors'
	when NumDoors is null then 'Not Set'
	else 'Unknown'
end as DoorDescription
from VehicleDetails