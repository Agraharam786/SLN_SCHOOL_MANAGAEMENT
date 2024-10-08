/*

select * from SLN_ADMISIONS where CLASS ='LKG' and Section='A'
order by 1

*/

declare @ACADEMIC_YEAR VARCHAR(10) ='2024-2025',
@CLASS_NAME varchar(10) ='LKG',
@LST_UPDATED_TMSP datetime = GETDATE(),
@LST_UPATED_ID varchar(50)='Purushotham',
@Section char(5) ='A'

delete from SLN_ADMISIONS where CLASS =@CLASS_NAME and Section=@Section



insert into SLN_ADMISIONS values('ANJALI. T','',@CLASS_NAME,@ACADEMIC_YEAR,'PACHIGUNTA','8985622580','F','','T TIRUMALA','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('BLESSY ANGLE.V','',@CLASS_NAME,@ACADEMIC_YEAR,'PADIRIKUPPAM','9014453713','F','','V PADMANABHAN','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('ESHITHA.N.S','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','8179218995','F','','T SIVA KUMAR','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('JOSHIKA .E','',@CLASS_NAME,@ACADEMIC_YEAR,'RAJULAKANDRIGA','9502730409','F','','E KRISHNA MOHAN','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('A PRATIKSHA','',@CLASS_NAME,@ACADEMIC_YEAR,'RAJULAKANDRIGA','9652439965','F','','A.JAGANNADHAN','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('SHAJEYA .T ','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','998562672','F','','S NAWAZ','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('THENDRAL .C','',@CLASS_NAME,@ACADEMIC_YEAR,'RKVB PETA','8978744254','F','','C DINESH KUMAR','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('VARSHINI .P ','',@CLASS_NAME,@ACADEMIC_YEAR,'C.D.KANDRIGA','7075715773','F','','P RAJASHEKHAR','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('G YOSHITHA','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','9030812480','F','','G BALAJI','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('BENARJI YADAV','',@CLASS_NAME,@ACADEMIC_YEAR,'MAMDEDU','9346029757','M','','B CHANDRA BABU','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('DEERAJ KUMAR.C','',@CLASS_NAME,@ACADEMIC_YEAR,'RAJULAKANDRIGA','9618508680','M','','C SELVAM','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('GUNADEEP.B','',@CLASS_NAME,@ACADEMIC_YEAR,'DUGUVAGERIGIDONA','8919192515','M','','B ESWARCHANDRAN','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('JITHESH .C.V ','',@CLASS_NAME,@ACADEMIC_YEAR,'PADIRIKUPPAM','9966007209','M','','C VENKATESH','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('JOSHITHA VARMA.Y','',@CLASS_NAME,@ACADEMIC_YEAR,'PADMASARASU','9492379589','M','','Y.JANAKIRAM','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('MANOJ.S','',@CLASS_NAME,@ACADEMIC_YEAR,'PADMASARASU','9491292817','M','','M.SURESH BABU','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('MUKUNSH AARYAN REDDY.P','',@CLASS_NAME,@ACADEMIC_YEAR,'RKVB PETA','9666045645','M','','P MADHU','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('PRAANJAL AARVISH.A.L','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','7093570893','M','','A.P LOKESH BABU','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('PRANAV.K','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR(PHW)','9848058440','M','','K MURALI','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('ROHITH.C','',@CLASS_NAME,@ACADEMIC_YEAR,'MURIREDDY KANDRIGA','9000896630','M','','C DURUVASULU','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('SURYA CHANDHRA .P ','',@CLASS_NAME,@ACADEMIC_YEAR,'POTHAVARI GUNTA','8374279294','M','','P MUNI SEKHAR ','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('VIHAN.A','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','9553566774','M','','A VENKATARAMANA','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('VISHNU VARDHAN.C','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR(PHW)','9553550033','M','','C UDAY KUMAR','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)

