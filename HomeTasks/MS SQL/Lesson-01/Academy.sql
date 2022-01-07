create database Academy --(create db)

exec sp_helpdb Academy --(get information about database)

drop database Academy --(delete db)

use Academy

--(Create Table)

create table Student
(
Id int identity,
Fullname nvarchar(25),
GroupOfStudent nvarchar(10),
Birthdate date,
Grade nvarchar(15)
)

--Add data to table

INSERT INTO dbo.Student (Fullname, GroupOfStudent, Birthdate, Grade) --(we can also don't define order inside "()") 
VALUES
('Eli','600.18A','1995-10-12','Forth'),
('Tural','600.19A','1999-05-11','Third'),
('John','622.19E','2000-9-19','Second'),
('Samir','610.20R','2000-11-12','First')


drop table Student --(delete table)

SELECT Fullname,GroupOfStudent FROM dbo.Student

SELECT * FROM Student ORDER BY Id DESC

SELECT * FROM Student WHERE GroupOfStudent like '%.19%';

SELECT * FROM dbo.Student 
where Fullname='Tural' and Grade='Third'

SELECT * FROM dbo.Student WHERE Fullname='John' or Grade='First'

SELECT * FROM dbo.Student WHERE Id in(2,4)

SELECT * FROM dbo.Student WHERE Id between 1 and 3

SELECT *FROM dbo.Student WHERE GroupOfStudent = '622.19E'

SELECT top(3) *FROM dbo.Student

SELECT *FROM dbo.Student ORDER BY Id offset 2 ROW 

SELECT *FROM dbo.Student ORDER BY Id offset 2 ROW FETCH FIRST 2  ROWS only


update Student
SET Fullname = 'Tural Eyvazov'
WHERE Id = 2

DELETE FROM Student WHERE Fullname = 'John'

DELETE Student WHERE Id in (1,5)

