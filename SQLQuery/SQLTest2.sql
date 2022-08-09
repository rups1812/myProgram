create database SQL_TEST_2;
use SQL_TEST_2;

create table Student
(Stud_id int primary key,
Sname varchar(20) not null,
Mobile bigint unique,
Year_Of_Pass year,
Batch_id int,
Status_id int,
foreign key(Batch_id) references Batch(Batch_id) on delete cascade on update cascade,
foreign key(Status_id) references Status(Status_id) on delete cascade on update cascade
);

create table Status
(Status_id int primary key,
Status_desc varchar(20)
);

create table Batch
(Batch_id int primary key,
BatchName varchar(30),
Teacher_id int,
foreign key(Teacher_id) references Teacher(Teacher_id) on delete cascade on update cascade
);

create table Score
(Stud_id int,
Test_Date date,
Topic varchar(30),
Marks_Obtained int,
primary key(Stud_id,Test_Date),
foreign key(Stud_id) references Student(Stud_id) on delete cascade on update cascade
);

create table Attendance
(Stud_id int,
Sdate date,
Present varchar(20)
foreign key(Stud_id) references Student(Stud_id) on delete cascade on update cascade
);

create table Teacher
(Teacher_id int primary key,
Tname varchar(20)
);


--1.Write a query to create Student and Score table. 
create table Student
(Stud_id int primary key,
Sname varchar(20) not null,
Mobile bigint unique,
Year_Of_Pass date,
Batch_id int,
Status_id int,
foreign key(Batch_id) references Batch(Batch_id) on delete cascade on update cascade,
foreign key(Status_id) references Status(Status_id) on delete cascade on update cascade
);

create table Score
(Stud_id int,
Test_Date date,
Topic varchar(30),
Marks_Obtained int,
primary key(Stud_id,Test_Date),
foreign key(Stud_id) references Student(Stud_id) on delete cascade on update cascade
);

--2.Write a query to add column Qualification to Student table. 
alter table Student add Qualification varchar(20);

--3.Write single query to create StudentCopy table which will have same structure and data of table.
select * into StudentCopy from Student;

--4.List all studentsname from july2018 who were absent for test on 18Aug2018.
select count(*),Sname from Student where Stud_id=(select Stud_id from Score Where Test_Date='2018-08-18');

--5.Update record of student Mithilesh from July2018 batch to Aug2018.Batch id of both batches is not known.
update Student set Sname='Mithilesh' where Stud_id=(select Stud_id from Student where Batch_id=(select Batch_id from Batch where BatchName between 'July2018' and 'Aug2018'));

--6.Assume there is field ‘student_count’ in batch table. Write a query to update this field by counting no of students in that batch.
update Batch set student_count =(select count(*) from Student s inner join Batch b on s.Batch_id=b.Batch_id);

--7.List all Students from July2018 whose qualification is “BE” and year of passing is 2018.
select * from Student where Stud_id=(select Stud_id from Student where Qualification='BE' and Year_Of_Pass=2018);

--8.List student name ,topic and topic wise marks of each student from July2018 batch.
select Sname,Topic,Marks_Obtained from Student s inner join Score sc on s.Stud_id=sc.Stud_id inner join Batch b on b.Batch_id=s.Batch_id where BatchName='July2018';

--9.Display batchname and Batchwise Placed student count for all batches from which less than 5 students are placed.
select BatchName,count(*) from Batch  group by Batch_id having count(*)>=5;

--10.Display top 3 students from july2018 batch with least attendance.
select * from Student s1 where 3=(select count(distinct(Sname)) from Student s2 where s1.Stud_id>=s2.Stud_id);

--11.Delete all records of those students from attendance who are ‘PLACED’
delete Student,Status from Student inner join Status on Student.Stud_id=Status.Status_id where Status.Status_desc='Placed';

--12.Delete all records of students whose average marks are less than 50.
delete Student,Score from Student inner join Score on Student.Stud_id=Score.Stud_id where Stud_id=(Select Stud_id,avg(Marks_obtained) from Score where Marks_Obtained<=50);

--13.Create a view to which shows sid name batchname. 
create view Sviews as select Stud_id,Sname,BatchName from Student,Batch where Student.Batch_id=Batch.Batch_id; 

--14.Create index so that retrieval of records is faster when retrieved based on status id
create index idxStatus_id on Status(Status_id);

--15.Give one example of left outer join using above database.
select Sname,BatchName from Student left join Batch on Student.Batch_id=Batch.Batch_id;





