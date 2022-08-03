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

alter table service_request add charges int;

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

--4.Show customer name, service description, charges of requests served by employees older than age 30. (make use of sub query)
select name,service_desc,charges from Service_Request where Emp_id = (select Emp_id from Employee where age >30 );

--5.Write a query to select customer names for whom employee ‘John’ has not served any request.(make use of sub query)
select name from customer where cust_id not in(select cust_id from Service_Request where emp_id=(select emp_id from employee where name='john'));


--6.Show employee name, total charges of all the requests served by that employee. Consider only ‘closed’ requests.
select name,sum(charges) from Employee e inner join Service_Request sr on e.emp_id=sr.emp_id inner join Service_Status ss on sr.status_id=ss.status_id where status_desc='closed' group by sr.emp_id;

--7.Show service description, customer name of request having third highest charges.


--8.Delete all requests served by ‘Sam’ as he has left the company.
delete from Service_Request where emp_id=(select emp_id from Employee where name='John');

--9.Delete all cancelled requests from request table.
delete from Service_Request where status_id = (select status_id from Service_Status where status_id = 3);

--10.Update charges of request raised by customer ‘Sony’. Add 10% to the charges if charges are less than 100.
update Service_Request set charges=charges*0.1 where charges < 100;

--11.Update totalRequests of customer table. TotalRequests should be total requests given by that customer.


--12.Create a view which will show customer name, service desc , employee name, service charges , status desc of requests which are not closed.


--14.Give one example of left outer join using above database.

--15.Show name of all employees who have same rating as employee ‘John’ 20.State at least 4 aggregate functions used in sql.