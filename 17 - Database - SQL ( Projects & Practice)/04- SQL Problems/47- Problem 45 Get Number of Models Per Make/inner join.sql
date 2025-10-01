
select makes.make,count(*) as numberOfModels
from makes inner join MakeModels on makes.MakeID = MakeModels.MakeID
group by make
order by numberOfModels desc