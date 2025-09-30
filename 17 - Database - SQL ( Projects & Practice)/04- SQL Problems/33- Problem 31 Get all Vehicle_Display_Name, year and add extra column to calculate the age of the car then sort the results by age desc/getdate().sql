
select VehicleDetails.Vehicle_Display_Name, VehicleDetails.Year,
Age = year(GETDATE()) - VehicleDetails.Year
from VehicleDetails
order by Age desc;
