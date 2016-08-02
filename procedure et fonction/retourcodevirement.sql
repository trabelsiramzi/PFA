create or replace function retourcodevirement ( ribb in number) return number is
codev number;
begin 
select code_v 
into codev
from compte 
where rib=ribb;
return codev;
end;
/