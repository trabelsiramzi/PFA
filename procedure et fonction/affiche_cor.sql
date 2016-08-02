CREATE   OR REPLACE PROCEDURE affiche_cord (vsolde out number,vnom out varchar2 , 
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
	  
   END;
/
