
select distinct VehicleDetails.Vehicle_Display_Name from VehicleDetails
where Engine_CC < (select avg(Engine_CC) as AvgEngineCC from VehicleDetails);