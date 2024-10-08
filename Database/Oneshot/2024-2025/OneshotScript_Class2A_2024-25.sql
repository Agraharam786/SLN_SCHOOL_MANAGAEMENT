
/*

select * from SLN_ADMISIONS where CLASS ='2' and Section='A'
order by 1
*/

declare @ACADEMIC_YEAR VARCHAR(10) ='2024-2025',
@CLASS_NAME varchar(10) ='2',
@LST_UPDATED_TMSP datetime = GETDATE(),
@LST_UPATED_ID varchar(50)='Purushotham',
@Section char(5) ='A'

delete from SLN_ADMISIONS where CLASS =@CLASS_NAME and Section=@Section

insert into SLN_ADMISIONS values('Baby shree  A','',@CLASS_NAME,@ACADEMIC_YEAR,'KESAVAKUPPPAM','7386896486','F','','A BASKHAR','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Chonsia. E T','',@CLASS_NAME,@ACADEMIC_YEAR,'TKM PETA','6304515997','F','','E THOJESWAR','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Divya .Bhati','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','8688534892','F','','SURESH BHATI','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('DILLI PRIYA.S','',@CLASS_NAME,@ACADEMIC_YEAR,'MAMBEDU','7680954789','F','','S MAHENDRA','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Hanshu .C','',@CLASS_NAME,@ACADEMIC_YEAR,'PADIRIKUPPAM','9381403821','F','','C MOTHILAL','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Jasmitha .P','',@CLASS_NAME,@ACADEMIC_YEAR,'KALIKIRINDLU','9666209069','F','','P JAGADEESH','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Kushika Priya .P','',@CLASS_NAME,@ACADEMIC_YEAR,'TKMPETA','9949459776','F','','P MURALI','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Mahira G.S','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','8179635928','F','','G.S ABDULLA','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Misha Angelina S.R','',@CLASS_NAME,@ACADEMIC_YEAR,'KATHERIPALLI','9703923683','F','','S RAVINDRAN','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Preethi N','',@CLASS_NAME,@ACADEMIC_YEAR,'RAJULAKANDRIGA','9676915796','F','','N HARINATH','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Priyanshu K','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','9959687068','F','','SHYAMLAL','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Sonakshi R','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','6377149816','F','','B RAKESH PATAL','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Sunvika A','',@CLASS_NAME,@ACADEMIC_YEAR,'RAJULAKANDRIGA','9652439965','F','','A JAGAN','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Ujjwala C','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','9491770706','F','','K JAGADEESAN','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Vinusha T','',@CLASS_NAME,@ACADEMIC_YEAR,'NEAR ITI(KNR)','9985035173','F','','T.SURESH BABU','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Aakash T','',@CLASS_NAME,@ACADEMIC_YEAR,'TKM PETA','9949021223','M','','T DILLI BABU','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Deekshith S','',@CLASS_NAME,@ACADEMIC_YEAR,'RKVB PETA','8179898014','M','','S RAMU','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Gagan P','',@CLASS_NAME,@ACADEMIC_YEAR,'PADMASARASU','6301676526','M','','P RAJENDRA','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Keerthi Charan V','',@CLASS_NAME,@ACADEMIC_YEAR,'RKVB PETA','7569433015','M','','V VINOD KUMAR','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Leela Sagar P','',@CLASS_NAME,@ACADEMIC_YEAR,'RKVB PETA','9182811484','M','','P DHAVAN KUMAR','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Mohmmad Ayan D','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','9642099696','M','','D KHADHARBASHA','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('PAVAN KALYAN.C','',@CLASS_NAME,@ACADEMIC_YEAR,'KNR','9553550033','M','','C UDAY','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('Rithvik Roshan ES','',@CLASS_NAME,@ACADEMIC_YEAR,'GERIGIDHONA','9502317102','M','','YOGAMUNI','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
insert into SLN_ADMISIONS values('VEEKSHITHA.B','',@CLASS_NAME,@ACADEMIC_YEAR,'RKVB PETA','9550973310','M','','B MAHENDRAN','',@Section,'',@LST_UPDATED_TMSP,@LST_UPATED_ID)
