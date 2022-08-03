create table thinkemp
(empid int primary key,
ename varchar(20) not null,
salary int,
mgrid int);

alter table thinkemp 
add constraint fkmgrid foreign key(mgrid) references thinkemp(empid);

select * from thinkemp;

select e1.ename 'EmpName',e2.ename 'Manager' from thinkemp e1 inner join thinkemp e2 on e1.mgrid=e2.mgrid;

select m.ename,count(*) from thinkemp e inner join thinkemp m on e.mgrid=m.empid group by m.ename having count(*) >=2;