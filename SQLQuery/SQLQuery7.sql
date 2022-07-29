create table Trainer
(tid int primary key,
tname varchar(20) not null,
experience int default 0,
qualification varchar(25)
);


create table student
(sid int primary key,
sname varchar(20),
percentage int,
trainerid int,
constraint fktidd foreign key(trainerid) references Trainer(tid)
);

drop table student;

 

insert into Trainer (tid,tname) values(101,'Deepa'),(102,'Kalyani'),(103,'Kriti');

insert into student values(2,'aksah',85,102);
select * from student;

update Trainer set experience=15,qualification='MCS' where tname='Deepa';
select * from Trainer;

update Trainer set experience=experience+5,qualification='MCS' where tname='Deepa';

delete from Trainer where tname='kriti';