select * from student;
drop table student;
create table student
(sid int primary key,
sname varchar(20) not null,
marks int check(marks>0),
mobile bigint,
city varchar(30) default'Pune');

select * from student;

insert into student values(
401,'Darshan',92,9275247865,'Mumbai');