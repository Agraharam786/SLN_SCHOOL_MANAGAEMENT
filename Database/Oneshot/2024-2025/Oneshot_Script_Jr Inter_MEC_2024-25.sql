/*

select * from SLN_ADMISIONS where CLASS ='Jr Inter' and Section='MEC'
order by 1

*/

declare @ACADEMIC_YEAR VARCHAR(10) ='2024-2025',
@CLASS_NAME varchar(10) ='Jr Inter',
@LST_UPDATED_TMSP datetime = GETDATE(),
@LST_UPATED_ID varchar(50)='Purushotham',
@Section char(5) ='MEC'

delete from SLN_ADMISIONS where CLASS =@CLASS_NAME and Section=@Section

