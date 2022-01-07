--CREATE DATABASE Company

--USE Company

CREATE TABLE Customers(
Id INT PRIMARY KEY IDENTITY,
[Name] nvarchar(25) NOT NULL CHECK(len ([Name]) > 2),
Surname nvarchar(25) NOT NULL CHECK(len (Surname) > 2),
Salary INT NOT NULL)

INSERT INTO Customers([Name], Surname, Salary)
VALUES
('Bayram','Aliyev', 650),
('Narmin','Talıbova', 950),
('Zahra','Aydın', 2500),
('John','Thomas', 8000),
('Sabir','Nurlu', 6550),
('Ali','Aliyev', 650)

SELECT * FROM Customers

--DROP TABLE Customers

UPDATE Customers
SET Salary = 5000 WHERE Id=1

DELETE FROM Customers WHERE [Name] = 'Ali' and Surname = 'Aliyev'

SELECT AVG(Salary) 'Avarage Salary' FROM Customers
SELECT MAX(Salary) 'Maximum Salary' FROM Customers
SELECT MIN(Salary) 'Minimum Salary' FROM Customers 

SELECT * FROM Customers WHERE Salary > (SELECT AVG(Salary) FROM Customers)  

SELECT [Name] + Surname 'Person gets MAX salary' FROM Customers WHERE Salary = (Select MAX(Salary) from Customers)

SELECT [Name] + Surname 'Person gets MIN salary' FROM Customers WHERE Salary = (Select MIN(Salary) from Customers)

--SELECT * FROM Customers WHERE Salary = (Select MAX(Salary) from Customers)

DROP TABLE Positions

create table Positions(
Id INT PRIMARY KEY IDENTITY,
[Name] nvarchar(25) NOT NULL CHECK(len ([Name]) > 2)
)

INSERT Positions([Name])
VALUES
('CEO'),
('CTO'),
('Security'),
('Mid Dev'),
('Jun Dev')

Alter table Customers 
ADD PositionID INT,
Foreign key (PositionID) references Positions(Id)


UPDATE Customers
SET PositionID = 5 where Customers.Id = 1
UPDATE Customers
SET PositionID = 3 where Customers.Id = 2
UPDATE Customers
SET PositionID = 4 where Customers.Id = 3
UPDATE Customers
SET PositionID = 1 where Customers.Id = 4
UPDATE Customers
SET PositionID = 2 where Customers.Id = 5

SELECT Customers.Name, Customers.Surname, Positions.Name FROM Customers
JOIN Positions on Customers.PositionID = Positions.Id

SELECT * from Customers
JOIN Positions on Customers.Id = Positions.Id

