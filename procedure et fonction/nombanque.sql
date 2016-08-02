create or replace function nombanque( ribb in number) return varchar2 is
vnomb banque.nom%type;
begin 
select nom
into vnomb
from banque,compte
where compte.rib=ribb
and compte.bic=banque.bic;
return vnomb;
end;
/