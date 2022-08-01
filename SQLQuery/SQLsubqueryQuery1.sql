--SUBQUERY

select * from employees;
select * from jobs;
select * from locations;

select first_name,last_name,salary from employees where salary=(select salary from employees where last_name='Bull');

select first_name,last_name from employees where job_id=(select job_id from jobs where job_title='IT');

select first_name,last_name from employees where manager_id in(select employee_id from employees where department_id in(select department_id from departments where location_id in(select location_id from locations where country_id='US')));

select first_name,last_name from employees where employee_id in(select manager_id from employees);

select first_name,last_name,salary from employees where salary > (select avg(salary) from employees);

select first_name,last_name,salary from employees where salary =(select min(salary) from employees);

select first_name, last_name, salary from employees where department_id IN (select department_id from departments where department_name like 'IT%') and salary > (select avg(salary) from employees);
