CREATE   OR REPLACE PROCEDURE premiercarac 
(carc out VARCHAR2 ,ribb in number) iS
    vrib number;
BEGIN
select UPPER(SUBSTR(prenom,0,1)),rib
into carc ,vrib
from client,compte
where compte.identifiant_c=client.identifiant AND compte.rib=ribb;
 END;
/
