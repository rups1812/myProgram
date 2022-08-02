create table Customer(
cust_id int primary key,
name varchar(20),
address_line1 varchar(30) default null,
address_line2 varchar(30),
city varchar(20) not null,
pin_code bigint,
totalRequests int
);

select * from Customer;

create table Service_Request
(service_id int primary key,
service_desc varchar(20) default null,
request_open_date date not null,
request_closed_date date,
cust_id int,
status_id int,
emp_id int,
foreign key(cust_id) references Customer(cust_id) on delete set null on update cascade,
foreign key(status_id) references Service_Status(status_id) on delete cascade on update cascade,
foreign key(emp_id) references Employee(emp_id) on delete cascade on update cascade);

create table Service_Status(
status_id int primary key check (status_id < 5 ),
);

Alter table service_status
add status_desc varchar(30);
-- values of id and desc are (1-OPEN, 2- IN_PROGRESS, 3-CLOSED,4-Cancelled)


create table Employee(
emp_id int primary key, 
name varchar(20), 
age int check (age>18),
requestsCompleted varchar(20),
emp_rating int 

);


sp_help Employee;
sp_help Service_Status;
sp_help Service_Request;
sp_help Customer;

--1.Write a query to create Employee table.
create table Employee(
emp_id int primary key, 
name varchar(20), 
age int check (age>18),
requestsCompleted varchar(20),
emp_rating int 
);

--2.Write a query to add column totalRequests (integer) to customer table (Assume it was not present earlier)
alter table Customer add totalRequest int;

--3.Write single query to create ReqCopy table which will have same structure and data of service_request table.
select * into ReqCopy from Service_Request;

--4.Show customer name, service description, charges	of requests served by employees older than age 30. (make use of sub query)
select service_desc,charges from Service_Request where Emp_id = (select Emp_id from Employee where age >30 );

--5.Write a query to select customer names for whom employee ‘John’ has not served any request.(make use of sub query)
select name from Customer where Cust_Id = (select Cust_Id from Service_Request where status_id = (select status_id from Service_Status where status_id = 2));

--6.Show employee name, total charges of all the requests served by that employee. Consider only ‘closed’ requests.
select name,charges from Employee,Service_Request where status_id =(select status_id from Service_Status where status_id = 3);

--7.Show service description, customer name of request having third highest charges.


--8.Delete all requests served by ‘Sam’ as he has left the company.
delete from Employee where name = 'Sam';

--9.Delete all cancelled requests from request table.
delete from Service_Request where status_id = (select status_id from Service_Status where status_id = 4);
