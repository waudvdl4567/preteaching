-- voegOrderToe(datum date, klant int, product int, hoeveelheid int) returns boolean
-- product dat beschikbaar is toevoegen
set @resultaat = voegOrderToe("2020-04-17",2 ,7 ,10);
select @resultaat;

-- voegOrderToe(datum date, klant int, product int, hoeveelheid int) returns boolean
-- product dat niet beschikbaar is toevoegen
set @resultaat = voegOrderToe("2020-04-17",2 ,9 ,5);
select @resultaat;


