
SELECT Makes.Make, VehicleDetails.*
FROM VehicleDetails 
				INNER JOIN Makes ON VehicleDetails.MakeID = Makes.MakeID
WHERE(VehicleDetails.Engine LIKE '%OHV%') AND (VehicleDetails.Engine_Cylinders = 4)