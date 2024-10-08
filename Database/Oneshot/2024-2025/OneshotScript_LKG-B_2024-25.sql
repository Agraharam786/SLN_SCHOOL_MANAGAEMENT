/*

select * from SLN_ADMISIONS where CLASS ='LKG' and Section='B'
order by 1

*/

declare @ACADEMIC_YEAR VARCHAR(10) ='2024-2025',
@CLASS_NAME varchar(10) ='LKG',
@LST_UPDATED_TMSP datetime = GETDATE(),
@LST_UPATED_ID varchar(50)='Purushotham',
@Section char(5) ='B'

delete from SLN_ADMISIONS where CLASS =@CLASS_NAME and Section=@Section


insert into SLN_ADMISIONS values('BHAVISYA.R','',@CLASS_NAME,@ACADEMIC_YEAR,'RAJULAKANDRIGA','9502338794','F','','R SRIKANTH','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('CHESHVIKA SAI .L','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','9948157933','F','','K LOKESH','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('GUNA GANPIKA.C','',@CLASS_NAME,@ACADEMIC_YEAR,'K.SUREKA','9492629079','F','','C.CHIRANJEEVI','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('NIREEKSHTHA.B','',@CLASS_NAME,@ACADEMIC_YEAR,'C.D.KANDRIGA','8143142975','F','','B SURESH','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('THANVI SREE','',@CLASS_NAME,@ACADEMIC_YEAR,'EDIGAPALLI','8106240302','F','','T.E.SWARIAH','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('THOSHINIKA .N ','',@CLASS_NAME,@ACADEMIC_YEAR,'RAJULAKANDRIGA','9866948336','F','','N SARAVAN','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('YASHIKA .T ','',@CLASS_NAME,@ACADEMIC_YEAR,'RKVB PETA','7036144106','F','','T.ASHOK','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('YASMITHA.M','',@CLASS_NAME,@ACADEMIC_YEAR,'INDIRA COLONY','7397302569','F','','M JAYAPAL','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('BLESSAN RAJ.E.T','',@CLASS_NAME,@ACADEMIC_YEAR,'TKM PETA','6304515997','F','','E.A.THOJESHWAR','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('DHRUVA.K','',@CLASS_NAME,@ACADEMIC_YEAR,'RAJULAKANDRIGA','9949884288','M','','R KIRAN','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('HARSHA .P','',@CLASS_NAME,@ACADEMIC_YEAR,'PADIRIKUPPAM','7416639915','M','','P PRAVEEN KUMAR','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('S.JOSEPH JOEL','',@CLASS_NAME,@ACADEMIC_YEAR,'TKM PETA','9502508829','M','','S MAHESH','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('JUBER .S','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','8179785920','M','','S MUNNA','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('MOKSHITH .E ','',@CLASS_NAME,@ACADEMIC_YEAR,'PACHIGUNTA','9100189953','M','','ER NAGARAJU','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('NANDHA KUMAR.K','',@CLASS_NAME,@ACADEMIC_YEAR,'VENUGOPALAPURAM','9701063637','M','','K RAVINDRA','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('RITHWIK .T ','',@CLASS_NAME,@ACADEMIC_YEAR,'PHW(KNR)','9701322543','M','','T THULASI RAM','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('RUSHWIN.M','',@CLASS_NAME,@ACADEMIC_YEAR,'KOTACHERUVU (KNR)','9600232563','M','','M.MANIVELU','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('E.T.THANISH','',@CLASS_NAME,@ACADEMIC_YEAR,'RKVB PETA','9666091496','M','','E HARI BABU','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('VISHAL KUMAR','',@CLASS_NAME,@ACADEMIC_YEAR,'EDIGA PALLI','9398839062','M','','K GURUVAIAH','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('N.NAVYA SREE','',@CLASS_NAME,@ACADEMIC_YEAR,'PHW(KNR)','9553550033','M','','C.UDAY KUMAR','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
