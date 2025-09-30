
select Vehicle_Display_Name from VehicleDetails
where Engine_CC = (select max(Engine_CC) as MaxEngineCC from VehicleDetails)
