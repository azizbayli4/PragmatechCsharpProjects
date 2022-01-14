--Quiz-Lesson-24

create database AcademyQuiz

use AcademyQuiz

drop table Groups

create table Groups(
ID INT PRIMARY KEY IDENTITY,
[Name] nvarchar(25) unique NOT NULL CHECK(len ([Name]) > 2),
)

create table Students(
Id INT PRIMARY KEY IDENTITY,
[Name] nvarchar(25) NOT NULL CHECK(len ([Name]) > 2),
Surname nvarchar(25) NOT NULL CHECK(len (Surname) > 2),
GroupID int NOT NULL,
foreign key (GroupID) references Groups(ID)
)

SELECT * FROM Students
SELECT * FROM Groups

INSERT INTO Groups([Name])
VALUES
('P221'),
('P124')
--('P221') --unique error


INSERT INTO Students([Name], Surname, GroupID)
VALUES
('Ali', 'Mansimov',1),
('Tural','Azimli',2),
('Aytac','Azimova',2),
('Turan','Asadli',2)

SELECT * FROM Students WHERE Students.GroupID=1

SELECT COUNT(Students.Id) as 'NumberOfStudentsAtGroupID = > 1' FROM Students where GroupID=1
SELECT COUNT(Students.Id) as 'NumberOfStudentsAtGroupID = > 2' FROM Students where GroupID=2

--select Groups.Name,Count(GroupId)'Count' from Students
--join Groups
--on Students.GroupId=Groups.Id
--group by Groups.Name

create view Student_Info as
SELECT Students.[Name] 'Name', Students.Surname 'Surname', Groups.[Name] 'Group' 
FROM Students
JOIN Groups on Students.GroupID = Groups.ID

SELECT * FROM Student_Info 

--SELECT Students.[Name] + '--' + Students.Surname + '--' + Groups.[Name] as 'StudentInfo' FROM Students
--JOIN Groups on Students.GroupID = Groups.ID
 
alter table Students
add Grade int

create procedure List_students @grade int
as
select *
from Students
where Grade > @grade

execute List_students 33
