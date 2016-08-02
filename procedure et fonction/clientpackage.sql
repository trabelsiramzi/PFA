create or replace package clientp as
PROCEDURE affiche_cord (vsolde out number,vnom out varchar2 , 
vprenom out varchar2 ,vnomb out varchar2,RIBB in  NUMBER);
PROCEDURE mise_a_jour
(vnom out VARCHAR2,vprenom out VARCHAR2,ribb in NUMBER);
PROCEDURE premiercarac 
(carc out VARCHAR2 ,ribb in number) ;
function verife_cl_log ( RIBB in  NUMBER,pass in varchar2 ) return varchar2;
function verificationsolde
(ribb in  number ,montant in number) return varchar2;
 
procedure virement
(vribd in NUMBER ,vribs in NUMBER  ,vmontant in NUMBER);



end clientp ;
/ 


CREATE OR REPLACE PACKAGE BODY clientp AS
PROCEDURE affiche_cord (vsolde out number,vnom out varchar2 , 
vprenom out varchar2 ,vnomb out varchar2,RIBB in  NUMBER) iS
   
   BEGIN
      SELECT solde,nom,prenom 
	  into vsolde,vnom,vprenom
	  from compte,client
	  where compte.identifiant_c=client.identifiant and compte.RIB=RIBB;
	 select nom 
	into  vnomb
	 from 
	 compte,banque 
	 where banque.bic=compte.bic and compte.RIB=RIBB ;
	  
   END affiche_cord;


PROCEDURE mise_a_jour
(vnom out VARCHAR2,vprenom out VARCHAR2,ribb in NUMBER) IS
BEGIN
SELECT nom,prenom
INTO vnom,vprenom
FROM compte,client
WHERE compte.identifiant_c=client.identifiant
AND compte.rib=ribb;
END mise_a_jour;

 PROCEDURE premiercarac 
(carc out VARCHAR2 ,ribb in number)  iS
    vrib number;
BEGIN
select UPPER(SUBSTR(prenom,0,1)),rib
into carc ,vrib
from client,compte
where compte.identifiant_c=client.identifiant AND compte.rib=ribb;
 END premiercarac;

 function verife_cl_log ( RIBB in  NUMBER,pass in varchar2 ) return varchar2 
is ok char ;
  vpass varchar2 (60) ; 
  v_count number :=0;
   BEGIN
   select count(*) 
   into v_count 
   from compte 
	  where RIB=RIBB  ;
	  if v_count=0 then 
	  ok:='x';
	  else
      select MDP 
	  into vpass
	  from compte 
	  where RIB=RIBB  ;
	 
	  if vpass <> pass then
		ok:='n';
		else
				ok:='o';
	  end if ;
	  end if;
	  	  return ok;
   
   END verife_cl_log;

function verificationsolde
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
end verificationsolde;


procedure virement
(vribd in NUMBER ,vribs in NUMBER  ,vmontant in NUMBER)is 
vmax number ;
vsolde number ;
vbic number ;
vcount number := 0;
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
select count(idho)
into vcount
from historique_operation ;
select max(idho)
into vmax
from historique_operation ;
if vcount = 0 then
vmax:=1;
else 
vmax:=vmax+1;
end if ;
insert into historique_operation values(vmax,vbic,sysdate,vribd,vribs,'virement',vmontant);

commit work;

commit work;
end virement;
end clientp;
/