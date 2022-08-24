create database Cafe_Asia;
create table register
(
    
   username varchar (50),
   password char(8) unique,
   confirm_password char(8),
   email varchar(20),
   contact_no integer,
    primary key(username,password)

);
drop table register;

create table payment
(
   
  card_type varchar(10),
  name_on_card varchar(50),
  card_no  varchar(16) primary key,
  card_expr_ varchar(10),
   cvv_no integer
   
);
drop table payment;

 
 
select * from register;

select* from payment;

create table food
(
   
  Item_Name varchar(50),
  Unit_Price float,
  quantity integer,
  Price float,
);




select* from food;
delete  from food;
drop table food;

create table delivary
(
    
   fname varchar(30),
   lname varchar(30),
   addr_line1 varchar (50),
   addre_line2 varchar (50),
   city varchar(40),
   contact_no integer,
   email varchar(50)

);
select * from delivary;

drop table delivary;