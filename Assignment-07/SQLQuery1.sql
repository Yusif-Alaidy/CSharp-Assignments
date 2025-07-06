-- actor table
create database task
go

use task
go

create schema actor_schema
go

create table actor_schema.actor
(
	a_id int primary key,
	a_fname varchar(20),
	a_lname varchar(20),
	a_gender varchar(1),
)
go


-- director table
use task
go

create schema director_schema
go

create table director_schema.actor
(
	d_id int primary key,
	d_fname varchar(20),
	d_lname varchar(20),
)
go


-- movie table
use task
go

create schema movie_schema
go

create table movie_schema.movie 
(
	m_id int primary key,
	m_title varchar(50),
	m_year int,
	m_time int,
	m_lang varchar(50),
	m_dt_rel date,
	m_rel_country varchar(5),
)
go
-- movie_director table
use task
go

create schema movie_director_schema
go

create table movie_director_schema.movie_dirctor 
(
	d_id int,
	m_id int ,

	primary key (d_id,m_id),
	foreign key (d_id) references director_schema.actor(d_id),
	foreign key (m_id) references movie_schema.movie(m_id),

)
go

-- movie cast table
use task 
go

create schema movie_cast_schema
go

create table movie_cast_schema.movie_cast
(
	a_id int ,
	m_id int ,
	role_ varchar(30),

	primary key (a_id, m_id),
	foreign key (a_id) references actor_schema.actor(a_id),
	foreign key (m_id) references movie_schema.movie(m_id),


)
go

-- reviewer 
use task
go

create schema reviewer_schema
go

create table reviewer_schema.reviewer
(
	r_id int primary key,
	r_name varchar(30),
)
go

-- genres
use task
go

create schema genres_schema
go

create table genres_schema.reviewer
(
	g_id int primary key,
	g_title varchar(20),
)
go

-- movie_genres
use task
go

create schema movie_genres_schema
go

create table movie_genres_schema.reviewer
(
	m_id int,
	g_id int,

	primary key (m_id, g_id),
	foreign key (m_id) references movie_schema.movie(m_id),
	foreign key (g_id) references genres_schema.reviewer(g_id),

)
go

-- rating
use task
go

create schema rating_schema
go

create table rating_schema.reviewer
(
	m_id int,
	r_id int,
	r_starts int,
	num_o_rating int,

	primary key (m_id, r_id),
	foreign key (m_id) references movie_schema.movie(m_id),
	foreign key (r_id) references reviewer_schema.reviewer(r_id),
)
go
