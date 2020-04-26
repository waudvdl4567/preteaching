DELIMITER $$
create function voegOrderToe(datum date, klant int, product int, hoeveelheid int) returns boolean
begin

set @boolVar = (select beschikbaar from producten where productID=product);

if @boolVar=true then
	insert into orders (bestelDatum,klantID,productID,bestelHoeveelheid)
	values (datum,klant,product,hoeveelheid);
end if;

return(@boolVar);
end$$
DELIMITER ;
	
    
    
    