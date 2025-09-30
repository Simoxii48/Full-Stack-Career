
select distinct VehicleDetails.Vehicle_Display_Name from VehicleDetails
where Engine_CC = ( select min(Engine_CC) as MinEngineCC from VehicleDetails)