CREATE DATABASE PB3;
USE PB3;
create table student 
(sid int, sname varchar(20), marks int);

insert into student values(3, 'Akash', 90);
insert into student(sid,sname) values(4,'Vedant');

select * from student;

drop table student;
