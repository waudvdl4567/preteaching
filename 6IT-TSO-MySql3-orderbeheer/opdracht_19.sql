use productenDB;
select orders.klantID, orders.productID, producten.productNaam, orders.bestelHoeveelheid, if (orders.afgehandeld,"afgehandeld", "open") as bestelstatus
from orders
inner join klanten on (orders.klantID=klanten.klantID)
inner join producten on (orders.productID=producten.productID)
where (klanten.klantNaam = "Colruyt NV Halle" and orders.bestelDatum>"2020-04-01");


