--Views --virtual table
--security reason
--complex query u require frequently u store  in view

select * from thinkemp;

create view vktemp
as select empid,ename from thinkemp;

select * from vktemp;
insert into vktemp values(9,'sonali');
delete from vktemp where empid=3;

--complex u cant insert,update,delete
--create view vk2
--as select batchid,count(*) as count from STUD group by batchid;

--select * from vk2;

--create view vk3
--as select sname,b,batchid,batchname from stud s inner join batch b on s.batchid=b.batchid;


