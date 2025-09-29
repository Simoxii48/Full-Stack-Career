
-- Using the having statement

-- having is used on the results
-- where is used on the data
select makes.make as Mark, count(*) as NumberOfVehicules
from VehicleDetails inner join makes on VehicleDetails.MakeID = makes.MakeID
where (VehicleDetails.Year between 1950 and 2000)
group by makes.make
having count(*) > 12000 -- Always use having clause in case of a condition with the group by statement (having is the where statement of the group by)
order by NumberOfVehicules desc

-- Solved without having clause
select * from 
( -- in between is like a view now so we can use the where statement directly
	select Makes.Make as Mark, count(*) as NumberOfVehicules
	from VehicleDetails inner join Makes on VehicleDetails.MakeID = Makes.MakeID
	where VehicleDetails.Year between 1950 and 2000
	group by Makes.make
) Result
where NumberOfVehicules > 12000
order by NumberOfVehicules desc;