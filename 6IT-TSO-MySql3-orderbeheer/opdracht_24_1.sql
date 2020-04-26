-- éénvoudige aanroep van de stored procedure
call zoekKlantOrders(5);

-- combinatie met een select-clause
call zoekKlantOrders((select klantID from klanten where klantNaam = "Colruyt NV Halle"));

-- je kan ook een MySQL variabele gebruiken
set @klantID = (select klantID from klanten where klantNaam = "AZ Sint Blasius Dendermonde");
call zoekKlantOrders(@klantID);
