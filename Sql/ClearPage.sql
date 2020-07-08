DELETE FROM UBF_Assemble_PartRelation
WHERE Page in (select ID from UBF_Assemble_Page where Code = '1983d8bd-8db2-4b88-bf71-c4513ea5eacd')
;
DELETE FROM UBF_Assemble_PageParameter
WHERE Page in (select ID from UBF_Assemble_Page where Code = '1983d8bd-8db2-4b88-bf71-c4513ea5eacd')
;
with
	PageID as
	(select ID from UBF_Assemble_Page where Code = '1983d8bd-8db2-4b88-bf71-c4513ea5eacd'),
	PageParameterID as
	(select ID from UBF_Assemble_PageParameter where Page in (select ID from PageID))
DELETE FROM UBF_Assemble_ParamBinding
WHERE PageParameter in (select ID from PageParameterID)
;
with
	PageID as
	(select ID from UBF_Assemble_Page where Code = '1983d8bd-8db2-4b88-bf71-c4513ea5eacd'),
	PagePartID as
	(select ID from UBF_Assemble_Part where Page in (select ID from PageID))
DELETE FROM UBF_Assemble_Part_Trl WHERE ID in (select ID from PagePartID)
;
DELETE FROM UBF_Assemble_Part
WHERE Page in (select ID from UBF_Assemble_Page where Code = '1983d8bd-8db2-4b88-bf71-c4513ea5eacd')
;
with
	PageID as
	(select ID from UBF_Assemble_Page where Code = '1983d8bd-8db2-4b88-bf71-c4513ea5eacd'),
	PageColumnID as
	(select ID from UBF_Assemble_PageColumn where Page in (select ID from PageID))
DELETE FROM UBF_Assemble_ColumnPart
WHERE PageColumn in (select ID from PageColumnID)
;
with
	PageID as
	(select ID from UBF_Assemble_Page where Code = '1983d8bd-8db2-4b88-bf71-c4513ea5eacd'),
	PageColumnID as
	(select ID from UBF_Assemble_PageColumn where Page in (select ID from PageID))
DELETE FROM UBF_Assemble_PageColumn_Trl
WHERE ID in (select ID from PageColumnID)
;
DELETE FROM UBF_Assemble_PageColumn
WHERE Page in (select ID from UBF_Assemble_Page where Code = '1983d8bd-8db2-4b88-bf71-c4513ea5eacd')
;
DELETE FROM UBF_Assemble_Page_Trl
WHERE ID in (select ID from UBF_Assemble_Page where Code = '1983d8bd-8db2-4b88-bf71-c4513ea5eacd')
;
DELETE FROM UBF_Assemble_Page
WHERE Code = '1983d8bd-8db2-4b88-bf71-c4513ea5eacd'
;
