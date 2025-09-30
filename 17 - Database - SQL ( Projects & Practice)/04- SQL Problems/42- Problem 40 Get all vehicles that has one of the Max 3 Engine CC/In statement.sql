
select vehicle_display_name from vehicleDetails
where engine_cc in
(
select distinct top 3 engine_cc from VehicleDetails
order by Engine_CC desc
)