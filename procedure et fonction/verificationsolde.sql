create or replace function verificationsolde
(ribb in  number ,montant in number)return varchar2
is
valide varchar2(10);
vsolde number ;
begin 
valide:='true';
select solde 
into vsolde
from compte 
where rib=ribb;
if montant>vsolde then
valide:='false';
end if;
return (valide);
end;
/
