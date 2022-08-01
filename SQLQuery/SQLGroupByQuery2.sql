--AGGREGATE FUNCTIONS AND GROUP BY ASSIGNMENT
select * from employees;

select count(job_id) from employees;

select sum(salary) from employees;

select min(salary) from employees;

select max(salary) from employees where job_id=9;

select avg(salary),count(*) from employees where department_id=90;

select round(max(salary),0),round(min(salary),0),round(sum(salary),0),round(avg(salary),0) from employees;

select job_id,count(*) from employees group by job_id;

select max(salary)-min(salary) difference from employees; 

select manager_id, min(salary) from employees where manager_id is not null group by manager_id order by min(salary);

select department_id , sum(salary) from employees group by department_id;

select job_id, avg(salary) from employees where job_id not in (9) group by job_id;

select job_id, max(salary), min(salary), sum(salary), avg(salary) from employees where department_id=90 group by job_id;

select job_id, max(salary) from employees group by job_id having max(salary) >=4000;

select department_id, avg(salary), count(*) from employees group by department_id having count(*) >10;