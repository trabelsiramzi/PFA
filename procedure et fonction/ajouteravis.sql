CREATE   OR REPLACE PROCEDURE ajouteravis(  VBIC in NUMBER,vdesc in varchar2  ) iS
idv number; 
   BEGIN
select max(idr)
into idv
from avis
where bic=vbic;
idv:=idv+1;
Insert into avis values (idv,vdesc,VBIC);
commit work;
   END ajouteravis;
/
