use productenDB;
alter table producten 
add column beschikbaar boolean default true; 

select * from producten;