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

-- Tasks