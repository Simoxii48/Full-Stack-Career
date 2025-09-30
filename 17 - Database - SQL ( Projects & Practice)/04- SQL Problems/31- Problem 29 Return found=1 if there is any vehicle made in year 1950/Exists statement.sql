
select Found = 1
where exists 
(
	-- top 1 used here for efficiency query regarding the question
	-- Return found=1 if there is any vehicle made in year 1950
	-- If there is only 1 no need to loop over all the data
	select top 1 * from VehicleDetails where year = 1950
)