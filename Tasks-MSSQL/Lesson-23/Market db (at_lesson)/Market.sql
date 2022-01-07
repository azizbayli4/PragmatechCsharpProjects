CREATE DATABASE Market

USE Market

CREATE TABLE Products(
ID INT IDENTITY NOT NULL,
[Name] VARCHAR(20) NOT NULL,
Price FLOAT NOT NULL
)

Alter table Products
Add Brand varchar(20)

Insert into Products
values
('Bread',0.50,'Sunbakery'),
('Chicken',4.89,'Mercan'),
('Milk',2.10,'Milla'),
('White Cheese',9.99,'Uch Inek'),
('Butter',15.40,'New Zelland'),
('Yoghurt',0.45,'Milla'),
('Oil',2.99,'Final'),
('Chocholate',2.99,'MaxFun'),
('Chocholate',1.99,'AlpenGold'),
('Cheese',7.99,'Ivanovka'),
('Banana',2.99,'Sun'),
('Spaghetti',0.99,'Doymak')


SELECT * FROM Products
Where Price>10

Select avg(Price) 'Average price' from Products 

--Select  CAST(avg(Price)as INT) from Products 

Select * From Products 
where Price<(Select avg(Price) from Products)

Select  Name + '  ' + Brand  'Product Info' from Products where LEN([Name])>5

