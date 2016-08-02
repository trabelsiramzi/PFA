CREATE   OR REPLACE PROCEDURE retbic
(vrib in  NUMBER ,tbic out   NUMBER) iS
    vbic number;
BEGIN
      select bic
	  into vbic
	  from compte 
	  where RIB=vrib 
	;
tbic:=vbic;
   END;
/