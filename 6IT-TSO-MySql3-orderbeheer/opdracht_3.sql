use productenDB;
create table producten(
productID int(11) not null auto_increment primary key,
productNaam varchar(255),
productStock int(11)
)
