--Select Statement

select * from employees;
select * from jobs;

select first_name,last_name from employees where salary not between 10000 and 15000;

select first_name,last_name,department_id from employees where department_id in(30,100) order by department_id asc;

select first_name,last_name,salary from employees where salary not between 10000 and 15000 and department_id in(30,100);

select first_name,last_name from employees where hire_date is null;

select first_name from employees where first_name like '%b%' and first_name like '%c%';

select first_name,job_id,salary from employees where job_id in(select job_id from jobs where job_title='programmer' or job_title='shipping clerk' and salary not in(4500,10000,15000));

select top(5) min(salary) from employees;

select distinct job_id from employees;

select first_name, last_name, salary, salary*.15 PF from employees;

select * from employees where last_name in('BLAKE','SCOTT','KING','FORD');