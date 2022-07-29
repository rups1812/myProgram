

CREATE TABLE Employee(
    EmpId int Primary Key, 
    FirstName varchar(20), 
    LastName varchar(20), 
    Email varchar(25), 
    PhoneNo varchar(25), 
    Salary int
);
select * from Employee;

insert into Employee values(501,'Shekhar','Patil','shekhar@gmail.com',9058789589,50000);