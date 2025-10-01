select max(totalmodels) as MaxNumberOfModels
from
(
	select makes.make, count(*) as TotalModels
	from makes inner join MakeModels on makes.MakeID = MakeModels.MakeID
	group by make
) R1