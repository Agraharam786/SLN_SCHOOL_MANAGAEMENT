
/*

select * from SLN_ADMISIONS where CLASS ='8' and Section='A'
order by 1

*/

declare @ACADEMIC_YEAR VARCHAR(10) ='2024-2025',
@CLASS_NAME varchar(10) ='8',
@LST_UPDATED_TMSP datetime = GETDATE(),
@LST_UPATED_ID varchar(50)='Purushotham',
@Section char(5) ='A'

delete from SLN_ADMISIONS where CLASS =@CLASS_NAME and Section=@Section


insert into SLN_ADMISIONS values('V.ANUSHYA','',@CLASS_NAME,@ACADEMIC_YEAR,'ANNUR','9908867400','F','','V.VASU','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('P.CHAYA','',@CLASS_NAME,@ACADEMIC_YEAR,'MANDAPAM ST ,KNR','8500196105','F','','P.RAMACHANDRA ','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('K.DIVYA SREE','',@CLASS_NAME,@ACADEMIC_YEAR,'GAJULAKANDRIGA','7893195352','F','','K.KUMAR RAJU','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('K.HUMAILA','',@CLASS_NAME,@ACADEMIC_YEAR,'KARVETINAGARAM','7672053902','F','','K.NAGARAJU','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('S.JASMITHA','',@CLASS_NAME,@ACADEMIC_YEAR,'KARVETINAGARAM','9494748400','F','','S.KUMARAJA','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('P.LOHITHA','',@CLASS_NAME,@ACADEMIC_YEAR,'AYYANGARIPALLI','9177689598','F','','P.RAMA GOVINDHA REDDY','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('K.MONIKA','',@CLASS_NAME,@ACADEMIC_YEAR,'KARVETINAGARAM','9491100562','F','','K.NETHAJI','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('G.PAVANI','',@CLASS_NAME,@ACADEMIC_YEAR,'PALLIPATTU','7639256813','F','','G.SREENIVASULU','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('K.SARANYA','',@CLASS_NAME,@ACADEMIC_YEAR,'VARALAKSHMI ST,KNR','8790952923','F','','K.NARENDRA BABU','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('G.THEJA','',@CLASS_NAME,@ACADEMIC_YEAR,'APPACHARI STREET','9346171814','F','','G.RAJENDRA','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('N.YUVASREE','',@CLASS_NAME,@ACADEMIC_YEAR,'MUNIREDDYKANDIGA','7993499961','F','','N.SEKHAR','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('P.PAVITHRA YADAV','',@CLASS_NAME,@ACADEMIC_YEAR,'KANAKAMMAKANDRIGA','9121651926','F','','P.CHANDRA BABU','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('A.BHAVYA SREE','',@CLASS_NAME,@ACADEMIC_YEAR,'PONNAGALLU','6383623582','M','','A.BHAKTHAVACHALAM','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('B.DHANUSH','',@CLASS_NAME,@ACADEMIC_YEAR,'DIGUVAGERIGADONA','9951921782','M','','B.VENUGOPAL','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('V.GOWTHAM','',@CLASS_NAME,@ACADEMIC_YEAR,'KARVETINAGARAM','9652274168','M','','V.VELU','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('B.HUTHIK SAI VARDHAN','',@CLASS_NAME,@ACADEMIC_YEAR,'KARVETINAGARAM','9441643065','M','','B.SWAMY RAJU','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('K.NIKHIL','',@CLASS_NAME,@ACADEMIC_YEAR,'TKM .PURAM','9052238138','M','','K.NITHYANANDHAN BABU','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('N.YASWANTH','',@CLASS_NAME,@ACADEMIC_YEAR,'KARVETINAGARAM','9494086719','M','','N.RUDRAIAH','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('D.SUSHMANTH','',@CLASS_NAME,@ACADEMIC_YEAR,'DRN.KANDRIGA','9701589313','M','','D.PANDU','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('A.DHANUSH','',@CLASS_NAME,@ACADEMIC_YEAR,'TKM .PURAM','9704213496','M','','A.NARESH REDDY','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('P.NANI','',@CLASS_NAME,@ACADEMIC_YEAR,'VIJAYAMABAPURAM','9346045112','M','','P.RAMULU','',@SECTION,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
