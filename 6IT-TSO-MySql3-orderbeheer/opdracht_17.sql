use productenDB;
update orders
set orders.afgehandeld=true
where (orderID = 1 or orderID=3 or orderID=4);

-- herneem - met een kleine aanpassing - opdracht 16 om het resultaat van deze query te controleren


