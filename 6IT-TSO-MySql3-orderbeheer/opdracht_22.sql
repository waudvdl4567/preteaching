-- tijdelijke tabel aanmaken. Deze is gelijkaardig aan de orders-tabel.
-- we voegen er een extra kolom 'beschikbaar' aan toe.
create temporary table temp_orders like orders;
alter table temp_orders add column beschikbaar boolean;

-- Het toe te voegen orden wordt in de tijdelijke tabel weggeschreven. 
-- Uit de producten-tabel halen we ook de beschikbaarheid. Die schrijven we ook in dezeproducten tijdelijke tabel. 
insert into temp_orders (bestelDatum,klantID,productID,bestelHoeveelheid,beschikbaar)
select
 "2020-04-15", 
(select klantID from klanten where klantNaam = "AZ Sint Blasius Dendermonde"),
(select productID from producten where productNaam = "Alco Spray 750 ml"), 10 ,
(select beschikbaar from producten where productNaam = "Alco Spray 750 ml") ;

-- invoeren van het order in de orders-tabel op voorwaarde dat het product beschikbaar is
insert into orders (bestelDatum,klantID,productID,bestelHoeveelheid)
select bestelDatum,klantID,productID,bestelHoeveelheid from temp_orders
where beschikbaar=true;

-- tijdelijke tabel verwijderen
drop table temp_orders;

