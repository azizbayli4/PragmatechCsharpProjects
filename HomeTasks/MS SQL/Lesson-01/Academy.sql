
--create database Academy --(create db)

--drop database Academy --(delete db)

--use Academy

----(Create Table)

--create table Student
--(
--Id int identity,
--Fullname nvarchar(25),
--GroupOfStudent nvarchar(10),
--Birthdate date,
--Grade nvarchar(15)
--)

----Add data to table

--INSERT INTO dbo.Student (Fullname, GroupOfStudent, Birthdate, Grade)
--values
--('Eli','600.18A','1995-10-12','Forth'),
--('Tural','600.19A','1999-05-11','Third'),
--('John','622.19E','2000-9-19','Second'),
--('Samir','610.20R','2000-11-12','First')



--select Fullname,GroupOfStudent from dbo.Student

--SELECT * FROM Student ORDER BY Id DESC

--SELECT * FROM Student WHERE GroupOfStudent like '%.19%';

--select * from dbo.Student 
--where Fullname='Tural' and Grade='Third'

--select * from dbo.Student where Fullname='John' or Grade='First'

--select * from dbo.Student where Id in(2,5)

--select * from dbo.Student where Id between 1 and 3

--select *from dbo.Student where GroupOfStudent = '622.19E'

--select top(3) *from dbo.Student

--select *from dbo.Student order by Id offset 2 row 

--select *from dbo.Student order by Id offset 2 row fetch first 2  rows only


--update Student
--set Fullname = 'Tural Eyvazov'
--where Id = 2

--DELETE FROM Student WHERE Fullname = 'John'

--DELETE Student WHERE Id in (1,4)

