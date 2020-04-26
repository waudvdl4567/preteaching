use productenDB;

-- zonder select
insert into orders(bestelDatum, klantID, productID, bestelHoeveelheid)
values 
( "2020-03-17", 2,2,5);

-- met select
insert into orders(bestelDatum, klantID, productID, bestelHoeveelheid)
values 
( "2020-03-15", 
(select klantID from klanten where klantNaam = "Colruyt NV Halle"),
(select productID from producten where productNaam = "Nitrilhandschoenen blauw medium 100 st/doos"),
10);

-- nog acht te gaan...

-- ("Apotheek De Rijbel Aalst"),
-- ("Colruyt NV Halle"),
-- ("Departement Welzijn, Gezondheid en Gezin - Vlaamse Gemeenschap"),
-- ("Rode Kruis afdeling Oost-Vlaanderen");
