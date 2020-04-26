use productendb;

-- mogelijkheid 1 
select orders.orderID,orders.klantID, klanten.klantNaam, orders.productID, producten.productNaam,orders.bestelHoeveelheid, orders.afgehandeld
from orders
inner join klanten on (orders.klantID=klanten.klantID)
inner join producten on (orders.productID=producten.productID);

-- alternatieve query

select orders.orderID, orders.klantID, klanten.klantNaam, orders.productID, producten.productNaam,orders.bestelHoeveelheid, if (orders.afgehandeld,"afgehandeld", "open") as bestelstatus
from orders
inner join klanten on (orders.klantID=klanten.klantID)
inner join producten on (orders.productID=producten.productID);

