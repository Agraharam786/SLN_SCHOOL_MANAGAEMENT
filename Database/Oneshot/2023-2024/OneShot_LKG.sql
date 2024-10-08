/*
select * from SLN_ADMISIONS
truncate table SLN_ADMISIONS

To insert data into SLN_ADMISIONS table
*/
declare @ACADEMIC_YEAR VARCHAR(10) ='2023-2024',
@CLASS_NAME varchar(10) ='LKG',
@LST_UPDATED_TMSP datetime = GETDATE(),
@LST_UPATED_ID varchar(50)='Purushotham'

INSERT into SLN_ADMISIONS VALUES ('KP ALANKRUTHA PRAVEEN' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'PHW, KARVETINAGARAM' ,'7893098841' ,'M' ,'' ,'K PRAVEEN KUMAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('P AYEESHA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'CHINNANAGAR, KARVETINAGARAM' ,'9908501374' ,'F' ,'' ,'P ABDUL SAMAD' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('A CHARESHMA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'RAJULAKANDRIGA' ,'9603415816' ,'F' ,'' ,'A DHANASEKHAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('K CHATURYAVARDHANA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'EAST STREET,KARVETINAGARAM' ,'9885607395' ,'' ,'' ,'K MANI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('V DHEEKSHITHA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'EAST STREET,KARVETINAGARAM' ,'6380476295' ,'F' ,'' ,'V RAVI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('V DISHITHA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'EAST STREET,KARVETINAGARAM' ,'9885607395' ,'F' ,'' ,'V RAVI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('S FATHIMA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'EAST STREET,KARVETINAGARAM' ,'7093889096' ,'F' ,'' ,'S ANJUR BASHA' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('N GAYANI' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'EAST STREET,KARVETINAGARAM' ,'9652022413' ,'F' ,'' ,'N KIRAN KUMAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('V GURUPRIYA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'CHINNANAGAR, KARVETINAGARAM' ,'7032000806' ,'F' ,'' ,'V AMARNADH ACHARI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('T HARSHITHA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'T.K.M. PETA' ,'7893238972' ,'F' ,'' ,'T DHANAPAL' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('G JOSHNA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'PADMASARASSU' ,'7729921038' ,'F' ,'' ,'G VENKATACHALAPATHI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('K KHANISKA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'R.K.V.B PETA' ,'9160539770' ,'F' ,'' ,'K VIJAYA KUMAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('R KRITIKA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'PADIRIKUPAM' ,'9677000340' ,'F' ,'' ,'R .CHANDRA SEKHAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('G LAKSHMI' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'VENUGOPALAPURAM' ,'9618779811' ,'F' ,'' ,'G RAJENDRA REDDY' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('K MANASA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'GG STREET, KARVETINAGARAM' ,'9676530958' ,'F' ,'' ,'K PANDURANGA' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('G MITHUSRI' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'APPACHARI STREET, KARVETINAGARAM' ,'9550075775' ,'F' ,'' ,'M GIRI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('G NITHYA SREE' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'PADMASARASSU' ,'8008440905' ,'F' ,'' ,'G MOHAN BABU' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('A SARANYA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'B.C COLONY, KARVETINAGARAM' ,'9515713036' ,'F' ,'' ,'A BALAJI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('B SAHASRA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'DIGUVAGERIGADONA' ,'9177606057' ,'F' ,'' ,'B GAJENDRA' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('C SHANVISREE' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'RAJULAKANDRIGA' ,'7993488221' ,'F' ,'' ,'C RAJASEKAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('V SHAHITHA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'INDHIRA COLONY' ,'9177901800' ,'F' ,'' ,'V VINOD KUMAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('K VIDYASREE' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'BRAHMIN STREET, KARVETINAGARAM' ,'8008639631' ,'F' ,'' ,'K GUNASEKHAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('N YAKSHITHA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'RAJULAKANDRIGA' ,'9676827542' ,'F' ,'' ,'N MAHENDRA' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('N BHANU PRAKASH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'PONNAGALLU' ,'9676376783' ,'M' ,'' ,'N MUNENDRAIAH' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('R BHARATH PATEL' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'BAZZAR STREET, KARVETINAGARAM' ,'8884902540' ,'M' ,'' ,'R CHETAN PATAL' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('E DRUVA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'R.K.V.B PETA' ,'9030070456' ,'M' ,'' ,'E SOMU' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('K DARSHITH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'BRAHMIN STREET, KARVETINAGARAM' ,'8520904395' ,'M' ,'' ,'K THYAGU' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('P DEEKSHITH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'MPDO OFFICE, KARVETINAGARAM' ,'9980494140' ,'' ,'' ,'P VENKATESULU' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('R DHAKSHAY' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'RAJULAKANDRIGA' ,'9550522658' ,'' ,'' ,'R RAJESH' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('B GUNADEEP' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'GERIGADON' ,'8919192515' ,'' ,'' ,'B.EASWAR CHANDRA' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('P HARSHAVARDHAN' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'VIJAMAMBAPURAM' ,'8466803163' ,'' ,'' ,'P MUNENDRA' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('N HARISH KALYAN' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'RAJULAKANDRIGA' ,'9542817108' ,'' ,'' ,'N GOVINDAIAH' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('S JASHWANTH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'INDHIRA COLONY' ,'9959026328' ,'' ,'' ,'S CHAKRAVARTHI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('R KHUSHAL REDDY' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'CHINNANAGAR, KARVETINAGARAM' ,'7993501899' ,'' ,'' ,'K DINESH' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('S KAMRAN' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'POLICESTATION, KARVETINAGARAM' ,'8374840917' ,'' ,'' ,'D AZARUDDIN' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('B MUNI THEJESH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'KAMBALAVEEDHI, KARVETINAGARAM' ,'9550832067' ,'' ,'' ,'B MOHAN' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('G MEDVIN' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'MAMBEDU' ,'9032117022' ,'' ,'' ,'G ESWARAIAH' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('G NIHANTH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'SINDURUPA STREET, KARVETINAGARAM' ,'9392761839' ,'' ,'' ,'G SRINIVASAN' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('N PANVITH KRISHNA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'UPPERAPALLI' ,'9620160256' ,'' ,'' ,'N VINOD KUMAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('S PREKSHITH REDDY' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'EAST STREET,KARVETINAGARAM' ,'7702197114' ,'' ,'' ,'S SANKAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('T PRITHVIK SAI' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'TKM PETA' ,'9704897949' ,'' ,'' ,'T.ELUMALAI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('M RUTHVIKSAI' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'VIJAMAMBAPURAM' ,'7981386447' ,'' ,'' ,'M MUNEENDRA' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('K SHYAMTHRIVEDH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'T.K.M. PETA' ,'7095658584' ,'' ,'' ,'K SAI KUMAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('T SAI CHARAN' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'ITI COLONY, KARVETINAGARAM' ,'9849140990' ,'' ,'' ,'T SURESH' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('J THANEESH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'GANDIKOTA STREET, KARVETINAGARAM' ,'9908499231' ,'' ,'' ,'J SARAVANA' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('K THANEESH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'SURAYYAPALYAM' ,'9573864911' ,'' ,'' ,'K MUNIRATHNAM ' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('P VEDANTH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'R.K.V.B PETA' ,'9550569344' ,'' ,'' ,'P LAKSHMIPATHI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('E.G YUVANANDAN' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'R.K.V.B PETA' ,'9666199321' ,'' ,'' ,'E GIRI BABU' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('K SATHWIK REDDY' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'KALIKIRINDLU' ,'9908736507' ,'' ,'' ,'K RAJENDRA REDDY' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('M DUSHANTH VARMA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'CHINNANAGAR, KARVETINAGARAM' ,'8106708663' ,'' ,'' ,'M CHANUKYA' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('K PAARTHIV SAI' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'RAJASTREET' ,'8688896067' ,'' ,'' ,'K RADHAKRISHNA' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('B SOHITH YADAV' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'UPPARAPALLI' ,'7619659458' ,'' ,'' ,'B HARI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('K.LIKITHA PRIAYA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'KNR' ,'9182004640' ,'' ,'' ,'K.NAGAMUNEDRA' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('P.RESHMITHA REDDY' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'KALIKERENDLU' ,'7993665590' ,'' ,'' ,'P.MURALI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('T.CHARVIK' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'TKM.PETA' ,'7569592625' ,'' ,'' ,'T.DHANASEKHAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('R.GURUCHARAN' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'RAJULAKANDRIGA' ,'9502338794' ,'' ,'' ,'R.SRIKANTH' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('R.ISAIAH PAUL' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'PADIRIKUPAM' ,'9182281054' ,'' ,'' ,'R.JASHUVA' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('T.LOHITH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'TKM PETA' ,'9704323634' ,'' ,'' ,'T.RAGHUPATHI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('G.SANJITH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'KNR' ,'9494369505' ,'' ,'' ,'G.GNANASEKAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('T.VARAPRASADH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'TKM PETA' ,'7032123162' ,'' ,'' ,'T.MURUGESH' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('N.YASWANTH' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'RAJULAKANDRIGA' ,'8106046480' ,'' ,'' ,'N.MAHENDRA' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('MS.VIKRAM ADITHYA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'RKVB.Peta' ,'9704915181' ,'' ,'' ,'SIVAKUMAR' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('C.SOHITH KUMAR' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'CHINTHAMANDI' ,'9492629076' ,'' ,'' ,'C.CHIRAN JEEVI' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
INSERT into SLN_ADMISIONS VALUES ('K.ISHITHA' ,'' ,@CLASS_NAME, @ACADEMIC_YEAR,'KNR' ,'9985682664' ,'' ,'' ,'K.MADHU' ,'' ,'A' ,'' ,@LST_UPDATED_TMSP , @LST_UPATED_ID )
