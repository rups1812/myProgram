--SUBQUERY

select * from employees;
select * from jobs;
select * from departments;

select first_name,last_name,salary from employees where salary=(select salary from employees where last_name='Bull');

select first_name,last_name from employees where job_id=(select job_id from jobs where job_title='IT');

select first_name,last_name from employees where manager_id in(select employee_id from employees where department_id in(select department_id from departments where location_id in(select location_id from locations where country_id='US')));

select first_name,last_name from employees where employee_id in(select manager_id from employees);

select first_name,last_name,salary from employees where salary > (select avg(salary) from employees);

select first_name,last_name,salary from employees where salary =(select min(salary) from employees);

select first_name, last_name, salary from employees where department_id IN (select department_id from departments where department_name like 'IT%') and salary > (select avg(salary) from employees);

select first_name,last_name,salary from employees where salary>(select salary from employees where last_name='Bell');

select first_name,last_name,salary from employees where salary=all(select min(salary) from employees group by department_id);

select first_name,last_name,salary from employees where salary>all(select avg(salary) from employees group by department_id);

select first_name,last_name,job_id,salary from employees where salary>all(select salary from employees where job_id=(select job_id from jobs where job_title='SH_CLERK'));

select first_name,last_name from employees where not exists( select * from employees where manager_id=employee_id);

select employee_id, first_name, last_name, (select department_name from departments d where e.department_id = d.department_id) department from employees e order by department;

select employee_id,first_name,last_name from employees as a where salary > (select avg(salary) from employees where department_id=a.department_id);

select distinct salary from employees e1 where 5 = (select count(distinct salary) from employees e2 where e1.salary <= e2.salary);

select distinct salary from employees e1 where 4 = (select count(distinct salary) from employees e2 where e2.salary <= e1.salary);

--select * from (select * from employees order by employee_id desc limit 10);

select * from departments where department_id not in(select department_id from employees);


select distinct salary from employees a where 3 >= (select count(distinct salary) from employees b where b.salary >= a.salary);

select distinct salary from employees a where 3 >= (select count(distinct salary) from employees b where b.salary <= a.salary);

select * from employees emp1 where(1) = (select count(distinct(emp2.salary)) from employees emp2 where emp2.salary>emp1.salary);