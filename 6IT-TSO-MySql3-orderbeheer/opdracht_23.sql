DELIMITER $$
create procedure toonOpenOrdersPeriode(startDatum date , eindDatum date)
begin
	select orders.orderID, orders.klantID, klanten.klantNaam
	from orders
	inner join klanten on (orders.klantID=klanten.klantID)
    where orders.bestelDatum > startDatum and orders.bestelDatum < eindDatum
	order by bestelDatum;    
end$$
DELIMITER ;






