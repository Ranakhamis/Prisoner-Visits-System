Create table prison
(
prison_id NUMBER(5) primary key,
Prison_name VARCHAR2(10) not null,
prison_location VARCHAR2(10) not null
);


Create table case
(
case_id NUMBER(5) primary key,
case_name VARCHAR2(10) not null
);

create table prisoner(
pr_name varchar2(20) UNIQUE not null,
pr_age number(2) not null,
pr_time number(2),
pr_id number(2) primary key,
pr_gender char,
prison_id number(2) references prison(prison_id) not null
);

create table visitor
(
visitor_id number(3) primary key,
pr_name varchar2(10) references prisoner(pr_name) not null,
visitor_name varchar2(10) not null
);



Create table policeman
(
po_id NUMBER(5) primary key,
po_name VARCHAR2(10) NOT NULL,
rank VARCHAR2(10) not null,
day_available VARCHAR2(10) not null
);


create table prisoner_case
(
case_id number(5) references case(case_id) not null,
pr_id number(2) references  prisoner(pr_id) not null,
constraint P_KD primary key(case_id,pr_id)
);


create table visit
(
v_id number(3) primary key,
day_date DATE not null,
start_time number(4) not null,
end_time number(4) not null,
pr_id number(2) references prisoner(pr_id) not null,
visitor_id number(3) references visitor(visitor_id) not null,
prison_id number(2) references prison(pr_id)not null,
po_id number(5) references policeman(po_id)not null
);