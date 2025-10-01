
select top 3 makes.make, count(*) as NumberOfModels
from makes inner join MakeModels on makes.MakeID = MakeModels.MakeID
group by make
order by NumberOfModels desc