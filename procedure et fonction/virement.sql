create or replace procedure virement
(vribd in NUMBER ,vribs in NUMBER  ,vmontant in NUMBER)is 
vmax number;
vsolde number ;
vbic number ;
begin 
select solde,bic 
into vsolde,vbic
from compte 
where rib=vribd;
vsolde:=vsolde+vmontant;
update compte set solde=vsolde where rib=vribd;
select solde 
into vsolde 
from compte 
where rib=vribs;
vsolde:=vsolde-vmontant;
update compte set solde=vsolde where rib=vribs;
select max(idho)
into vmax
from historique_operation ;
vmax:=vmax+1;

insert into historique_operation values(vmax,vbic,sysdate,vribd,vribs,'virement',vmontant);

commit work;
end;
/