-- 1. Create a table named "Employees" with columns for ID (integer), Name (varchar), and Salary (decimal) 
create database task2
go

use task2
go

create table employees 
(
	eid int,
	ename varchar(20),
	esalary decimal(9,2)
)


-- 2. Add a new column named "Department" to the "Employees" table with data type varchar(50)
alter table employees
add department varchar(50);


-- 3. Remove the "Salary" column from the "Employees" table.
alter table employees
drop column esalary;

-- 4. Rename the "Department" column in the "Employees" table to "DeptName".
EXEC sp_rename 'employees.department', 'dep_name', 'COLUMN';

-- 5. Create a new table called "Projects" with columns for ProjectID (integer) and ProjectName (varchar)
create table projects 
(
	project_id int primary key,
	project_name varchar(30),
)

-- 6. Add a primary key constraint to the "Employees" table for the "ID" column.
alter table employees
drop column eid;

alter table employees
add eid int identity(1,1);

-- 7. Add a unique constraint to the "Name" column in the "Employees" table.
alter table employees
ADD CONSTRAINT unique_employee_name UNIQUE (Name);

-- 8. Create a table named "Customers" with columns for CustomerID (integer), FirstName (varchar), LastName (varchar), and Email (varchar), and Status (varchar).
create table customer
(
	cid int primary key,
	fname varchar(25),
	lname varchar(25),
	email varchar(50),
	cstatus varchar(20)
)

-- 9. Add a unique constraint to the combination of "FirstName" and "LastName" columns in the "Customers" table
alter table customer
ADD CONSTRAINT unique_fullname UNIQUE (fname, lname);


-- 10. Create a table named "Orders" with columns for OrderID (integer), CustomerID (integer), OrderDate (datetime), and TotalAmount (decimal).
create table orders
(
	oId int primary key,
	cid int,
	order_date datetime,
	total_amount decimal(8,2)

	foreign key (cid) references customer(cid),
)

-- 11. Add a check constraint to the "TotalAmount" column in the "Orders" table to ensure that it is greater than zero.
ALTER TABLE orders
ADD CONSTRAINT chk_total_amount CHECK (total_amount > 0);

-- 12. Create a schema named "Sales" and move the "Orders" table into this schema.
use task2
create schema sales;
ALTER SCHEMA sales TRANSFER orders;

-- 13. Rename the "Orders" table to "SalesOrders."
EXEC sp_rename 'orders', 'sales_orders';
