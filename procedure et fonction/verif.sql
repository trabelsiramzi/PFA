CREATE   OR REPLACE function verife_cl_log ( RIBB in  NUMBER,pass in varchar2 ) return varchar2 
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
   
   END;
/
