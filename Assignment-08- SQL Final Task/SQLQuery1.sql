create database barwon_health;
use barwon_health

-- create tables
create table patient 
(
	patient_id int primary key,
	patien_name varchar(25),
	patient_age int,
	patient_address varchar(50),
	medicare_card_num varchar(50),
	contact_id int,
	foreign key (contact_id) references contact(contact_id)

)

create table contact 
(
	contact_id int primary key,
	phone varchar(14),
	email varchar(25)
)

create table doctore
(
	doc_id int primary key,
	doc_name varchar(50),
	doc_email varchar(75),
	specialty varchar(50),
	year_exp int,
	contact_id int,

	foreign key (contact_id) references contact(contact_id)
)

create table drugs
(
	drugs_id int primary key,
	drugs_name varchar(50),
	strength decimal(3,1),
	companies_id int,

	foreign key (companies_id) references companies(comp_id)
)

create table companies
(	
	comp_id int primary key,
	comp_name varchar(50),
	address varchar(50),
	phone_number varchar(14),

	
)

create table doctore_drugs
(
	doc_id int,
	drugs_id int,
	date date,
	quantity int,

	primary key (doc_id, drugs_id),
	foreign key (doc_id) references doctore(doc_id),
	foreign key (drugs_id) references drugs(drugs_id),

)

create table Prescription
(
	patient_id int,
	drugs_id int,

	primary key (patient_id, drugs_id),
	foreign key (patient_id) references patient(patient_id),
	foreign key (drugs_id) references drugs(drugs_id),

)

-- Tasks

--- 1.SELECT: Retrieve all columns from the Doctor table.
select * 
from doctore

--- 2.ORDER BY: List patients in the Patient table in ascending order of their ages.
select *
from patient
order by patient_age;

---3.OFFSET FETCH: Retrieve the first 10 patients from the Patient table, starting from the 5th record.
select *
from patient
order by patient_id
offset 4 rows
fetch next 10 rows only;

--- 4.SELECT TOP: Retrieve the top 5 doctors from the Doctor table.
select top 5 *
from doctore
order by doc_id

--- 5.SELECT DISTINCT: Get a list of unique address from the Patient table.
SELECT DISTINCT patient_address
FROM Patient;

--- 6.WHERE: Retrieve patients from the Patient table who are aged 25.
select *
from patient
where patient_age = 25

--- 7.	NULL: Retrieve patients from the Patient table whose email is not provided.
select p.*
from patient p join contact c
on p.contact_id = c.contact_id
where c.contact_id is null

--- 8.	AND: Retrieve doctors from the Doctor table who have experience greater than 5 years and specialize in 'Cardiology'.
select *
from doctore
where year_exp = 5 and specialty = 'cardiology'

--- 9.	IN: Retrieve doctors from the Doctor table whose speciality is either 'Dermatology' or 'Oncology'.
select *
from doctore
--where specialty = 'Dermatology' or specialty = 'Dermatology'
where specialty in ('Dermatology', 'Oncology')

--- 10.	BETWEEN: Retrieve patients from the Patient table whose ages are between 18 and 30.
select *
from patient
where patient_age >= 18 and patient_age <= 30

--- 11.	LIKE: Retrieve doctors from the Doctor table whose names start with 'Dr.'.
select *
from doctore
where doc_name like 'dr.%'

--- 12.	Column & Table Aliases: Select the name and email of doctors, aliasing them as 'DoctorName' and 'DoctorEmail'.
SELECT 
    doc_name AS DoctorName,
    email AS DoctorEmail
FROM doctore d join contact c
on d.contact_id = c.contact_id

--- 13.Joins: Retrieve all prescriptions with corresponding patient names.
select p.patient_id, d.drugs_id 
from Prescription dp join patient p on dp.patient_id = p.patient_id
join drugs d on dp.drugs_id = d.drugs_id

--- 14.	GROUP BY: Retrieve the count of patients grouped by their cities.
select patien_name, count(*) cities
from patient
group by patient_address, patien_name

--- 15.	HAVING: Retrieve cities with more than 3 patients.
select patient_address, count(*) total_patient
from patient
group by patient_address
having count(*) > 3;

--- 16.	GROUPING SETS: Retrieve counts of patients grouped by cities and ages.
SELECT 
    patient_address AS city,
    patient_age AS age,
    COUNT(*) AS total_patients
FROM Patient
GROUP BY GROUPING SETS (
    (patient_address),
    (patient_age)
);

--- 17.	CUBE: Retrieve counts of patients considering all possible combinations of city and age.
select patient_address as city, patient_age as city, count(*) as count
from patient 
group by cube (patient_address, patient_age)

--- 18.	ROLLUP: Retrieve counts of patients rolled up by city.
SELECT 
    patient_address AS city,
    COUNT(*) AS total_patients
FROM Patient
GROUP BY ROLLUP (patient_address);

--- 19.	EXISTS: Retrieve patients who have at least one prescription.
SELECT *
FROM Patient p
WHERE EXISTS (
    SELECT 1
    FROM Prescription pr
    WHERE pr.patient_id = p.patient_id
);

--- 20.	UNION: Retrieve a combined list of doctors and patients.
SELECT 
    doc_name AS full_name
FROM doctore

UNION

SELECT 
    patien_name AS full_name,
    c.email
FROM Patient p
JOIN Contact c ON p.contact_id = c.contact_id;

---21.Common Table Expression (CTE): Retrieve patients along with their doctors using a CTE.
with doctor_patient as
(
	select *
	from patient p join doctore d
	on  p.doc_id = d.doc_id
)

select * from doctor_patient;


--- 22.	INSERT: Insert a new doctor into the Doctor table.
INSERT INTO contact(contact_id, phone, email)
VALUES (4, '01012345678', 'test@example.com');

INSERT INTO doctore(doc_id, doc_name, doc_email, specialty, year_exp, contact_id)
VALUES (1, 'doc1', 'test@example.com', 'Dermatology', 5, 1);


--- 23.	INSERT Multiple Rows: Insert multiple patients into the Patient table.
insert into patient(patient_id, patien_name, patient_age, patient_address, medicare_card_num, contact_id, doc_id)
values 
(1, 'yusif', 22, 'giza', '012345', 2,1),
(2, 'ali', 21, 'cairo', '012345', 3,1),
(3, 'khaled', 10, 'giza', '012345', 4,1)

---24.	UPDATE: Update the phone number of a doctor.
update c
set phone = '0000000'
from contact c join doctore d
on c.contact_id = d.contact_id
where d.doc_id = 1

--- 25.	UPDATE JOIN: Update the city of patients who have a prescription from a specific doctor.
UPDATE Patient
SET patient_address = 'Updated City'
WHERE patient_id IN (
    SELECT pr.patient_id
    FROM Prescription pr
    JOIN Drugs d ON pr.drugs_id = d.drugs_id
    JOIN doctore du ON d.doc_id = du.doc_id
    WHERE du.doc_name = 'Dr. Ahmed'
);

--- 26.	DELETE: Delete a patient from the Patient table.
delete patient
where patient_id = 1

--- 27.	Transaction: Insert a new doctor and a patient, ensuring both operations succeed or fail together.
BEGIN TRANSACTION;
-- 1. Insert doctor
INSERT INTO doctore(doc_id, doc_name, contact_id)
VALUES (101, 'Dr. Ahmed Yusif', 201);

-- 2. Insert patient linked to the same contact (or same doctor if needed)
INSERT INTO Patient (patient_id, patien_name, patient_age, patient_address, medicare_card_num, contact_id)
VALUES (501, 'Sara Ali', 28, 'Cairo', 'MC987654', 201);
-- If all good
COMMIT;

--- 28.	View: Create a view that combines patient and doctor information for easy access.
create view patientDoctore as
select p.patient_id, p.patien_name, d.doc_id, d.doc_name
from patient p join doctore d 
on p.doc_id = d.doc_id;

select *
from patientDoctore

--- 29.	Index: Create an index on the 'phone' column of the Patient table to improve search performance.
create index index_id
on contact(phone)

--- 30.	Backup: Perform a backup of the entire database to ensure data safety.
BACKUP DATABASE barwon_health
TO DISK = 'C:\Backups\barwon_health.bak'
WITH FORMAT, MEDIANAME = 'DBBackup', NAME = 'Full Backup';
