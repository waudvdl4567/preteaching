DELIMITER $$
create procedure zoekKlantOrders(klantID int)
begin
	select orders.productID, producten.productNaam, orders.bestelHoeveelheid
	from orders
	inner join producten on (orders.productID=producten.productID)
    where orders.klantID = klantID;
end$$
DELIMITER ;

