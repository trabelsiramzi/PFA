CREATE OR REPLACE PACKAGE p1 AS 
        TYPE t_cursor IS REF CURSOR ; 
        Procedure extrait (RIBB in number ,date1 in varchar2,date2 in varchar2,io_cursor IN OUT t_cursor); 
   END p1;
   / 
      CREATE OR REPLACE PACKAGE BODY p1 AS
Procedure extrait (RIBB in number ,date1 in varchar2,date2 in varchar2, io_cursor IN OUT  t_cursor) is 
v_cursor t_cursor;
BEGIN
OPEN v_cursor FOR 
 SELECT * 
      FROM Historique_operation
	  where ribd=RIBB and date_ho BETWEEN TO_DATE (date1, 'dd/mm/yy') AND TO_DATE (date2, 'dd/mm/yy');
	  io_cursor := v_cursor;
	  
	  end extrait;
	  end p1;
	  
	  /