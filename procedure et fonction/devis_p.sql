CREATE OR REPLACE PACKAGE devise_ech AS 
        TYPE t_cursor IS REF CURSOR ; 
        Procedure affiche_devis (vrib in number ,io_cursor IN OUT t_cursor); 
   END devise_ech;
   / 
      CREATE OR REPLACE PACKAGE BODY devise_ech AS
Procedure affiche_devis (vrib in number ,io_cursor IN OUT  t_cursor) is 
v_cursor t_cursor;
BEGIN
OPEN v_cursor FOR 
 SELECT * 
      FROM devis,compte 
	  where devis.bic=compte.bic and compte.rib=vrib;
	  io_cursor := v_cursor;
	  
	  end affiche_devis;
	  end devise_ech;
	  /