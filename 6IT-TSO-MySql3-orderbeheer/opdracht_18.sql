select orders.klantID, klanten.klantNaam, orders. productID, producten.productNaam, orders.bestelHoeveelheid
from orders
inner join klanten on (orders.klantID=klanten.klantID)
inner join producten on (orders.productID=producten.productID)
where orders.afgehandeld=false;