create table empp
(eid int primary key identity(101,1),
ename varchar(20) not null,
mobile bigint);

insert into empp(ename,mobile) values('rupesh',9874561234);
insert into empp(ename,mobile) values('Ajinkya',965471234);
select * from empp;

create unique nonclustered index idxmb on empp(mobile)
where mobile is not null;
insert into empp(ename) values('Sapana');