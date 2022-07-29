create database DoctorInfo;
use DoctorInfo;

create table Doctor
(did int primary key,
dname varchar(25) not null,
daddress varchar(50),
qualification varchar(25),
noofpatient_handled int default 0,
);


select * from Doctor;

insert into Doctor Values (101 , 'Akash' , 'Mumbai' , 'MD' , 500) , (102 , 'Paresh' , 'Pune' , 'BHMS' , 1000) ,
(103 , 'Darshan' , 'Aurangabad' , 'BAMS' , 1500) , (104 , 'Ruhi' , 'Nashik' , 'BHMS' , 2000);
insert into Doctor values(105,'Rupesh','Pune','MD',2500);

select qualification from Doctor where qualification='MD';



create table PaitientMaster
(pcode int primary key,
pname varchar(25) not null,
paddr varchar(50),
age int not null,
gender varchar(10) check(gender in ('male', 'female','unknown')),
bloodgroup varchar(10)
);

select * from PaitientMaster;

insert into PaitientMaster values(11,'Rupesh' , 'pune' , 25 , 'male' , 'B-') , (22,'Kedar' , 'Sangali' , 24 , 'male' , 'B+'),
(33,'Pranali' , 'Nashik' , 22 , 'female' , 'AB-') , (44,'Shivani' , 'Jalgaon' , 27 , 'female' , 'AB+' ),
(55,'Bhavesh' , 'pune' , 29 , 'male' , 'AB+' );


alter table PaitientMaster drop constraint PK__Paitient__293812AAEC41E1E4;
alter table PaitientMaster add primary key(pcode);





create table AdmittedPatient
(entry_date date not null,
discharge_date date not null,
wardno int,
disease varchar(20),
PaitientMastercode int,
doctorid int,
foreign key(PaitientMastercode) references PaitientMaster(pcode),
foreign key(doctorid) references Doctor(did)
);


select * from AdmittedPatient;

insert into AdmittedPatient values ( '2022-02-4' , '2022-02-8',5 , 'Fever' , 11, 101);
insert into AdmittedPatient values ( '2022-02-8' , '2022-02-16',8 , 'Cold' , 22 , 101);
insert into AdmittedPatient values ( '2022-03-5' , '2022-03-10',10 , 'Typhoid' , 33 , 102);
insert into AdmittedPatient values ( '2022-03-20' , '2022-03-28',6 , 'Maleriya' , 44 , 103);
insert into AdmittedPatient values ( '2022-04-2' , '2022-04-6',4 , 'Dengu' , 55 , 104);


alter table AdmittedPatient add discharge_date date;
alter table AdmittedPatient alter column wardno varchar(10);
alter table AdmittedPatient drop constraint FK__AdmittedP__docto__3C69FB99;

create table Bill
(billno int primary key,
billamount bigint not null,
PaitientMastercode int,
foreign key(PaitientMastercode) references PaitientMaster(pcode)
);


select * from Bill;

insert into Bill values (51 , 70000, 11);
insert into Bill values (52 , 60000, 22);
insert into Bill values (53 , 80000, 33);
insert into Bill values (54 , 90000, 44);
insert into Bill values (55 , 50000, 55);



sp_help Doctor;
sp_help PaitientMaster;
sp_help AdmittedPatient;
sp_help Bill;