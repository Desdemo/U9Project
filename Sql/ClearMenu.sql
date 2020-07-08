delete from UBF_Assemble_Menu_Trl 
where ID in (select ID from UBF_Assemble_Menu where Code = '983f623f-8d72-4bdf-b63b-1d8f3aa37db6')
;
delete from UBF_Assemble_Menu
where Code = '983f623f-8d72-4bdf-b63b-1d8f3aa37db6'
;