use productenDB;
create table orders(
orderID int(11) not null auto_increment primary key,
bestelDatum date not null,
klantID int(11),
productID int(11),
bestelHoeveelheid int(11),
afgehandeld boolean default false,
foreign key (productID) references producten(productID),
foreign key (klantID) references klanten(klantID)
)