

SELECT Makes.Make, COUNT(*) AS NumberOfModels
FROM Makes 
			INNER JOIN MakeModels ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make
having COUNT(*) = 
(
		select Min(NumberOfModels) as MinNumberOfModels
		from
		(
				SELECT MakeID, COUNT(*) AS NumberOfModels
				FROM MakeModels
				GROUP BY MakeID								
		) R1
)