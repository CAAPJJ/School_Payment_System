create Database Online_Payment;
use Online_Payment;

create table Schoole(
School_Id int IDENTITY(1,1) primary key ,
School_Name varchar(30),
School_Email varchar(50) unique,
User_Name varchar(10) unique,
Password varchar(50),
Adress varchar(20),
Phone_number varchar(15)
)
insert into Schoole values('Agazian','Aga@gmail.com','@Agazian','aga1234',
	'Mexico','0910797706');
	select *from schoole
drop table School

create table Student(
School_Id int,foreign key (School_Id ) references Schoole(School_Id),
Student_id int IDENTITY(1,1) primary key,
First_Name varchar(20),
Last_Name varchar (20),
Sex varchar(10),
Age int,
User_Name varchar(10) unique,
Password varchar(50),
Email varchar(50) unique,
Current_Class int,
Adress varchar(20),
Phone_number varchar(15),
)
select * from Student;

drop  table Student

create table fee(
fee_id int IDENTITY(1,1) primary key,
class int,
amount float,
)
drop table fee

create table Payment(
Payment_Id int IDENTITY(1,1) primary key,
fee_id int,foreign key (fee_id) references fee(fee_id),
Parent_Id int,foreign key (Parent_Id ) references Parent(Parent_Id),
School_Id int,foreign key (School_Id ) references Schoole(School_Id),
Student_Id int,foreign key (Student_Id ) references Student(Student_Id),
Pay_Date datetime NOT NULL default GETDATE()
)

drop table Payment

create table Parent(
Parent_Id int IDENTITY(1,1) primary key,
First_Name varchar(20),
Last_Name varchar(20),
Sex varchar(10),
Age int,
User_Name varchar(10) unique,
Password varchar(50),
Email varchar(50) unique,
Phone_number varchar(15),
)
select * from Parent;

drop table Parent

create table Loan(
loan_id int IDENTITY(1,1) primary key,
Credit_Amount float,
date_loan date not null default GetDate(),
Parent_Id int,foreign key (Parent_Id ) references Parent(Parent_Id),
Student_Id int,foreign key (Student_Id ) references Student(Student_Id),
School_Id int,foreign key (School_Id ) references Schoole(School_Id),
)

create table jase(
User_Name varchar(10),
password varchar(20),
First_Name varchar(10),
Last_Name varchar(10)
)

insert into jase values('run','1234','Leul','Kahssaye');
select *from jase;
drop table jase

drop table Loan
drop table Parent
drop table fee
drop table Student
drop table Payment
drop table Schoole

					create trigger input_validation on Parent  School for insert
					as
					declare @First_name varchar(25),@Last_name varchar(25),@email varchar(50),@username varchar(25),@phone_numebr int
					select @First_name=i.First_name ,@Last_name=i.Last_name,@email=i.email,@username=i.User_Name,@phone_numebr=i.phone_number from inserted i
					if(@First_name like ('%[^a-zA-z0-9]%') or @Last_name like ('%[^a-zA-z0-9]%')or @email not like '%_@__%.__%'or @email like ' %_'
					or @username not like '%@__%' or (len(@username)<6)or (len(@username)>10) or
					not(len(@phone_numebr)=9) or (@phone_numebr >999999999 or @phone_numebr<0900000000) )
					begin  print 'Invalid Input check your first name and last name,email address,username or phone number' rollback transaction end

					drop trigger input_validation