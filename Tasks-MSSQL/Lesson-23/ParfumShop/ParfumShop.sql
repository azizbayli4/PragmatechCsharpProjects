create database ParfumShop

use ParfumShop

--drop table Parfum
-------------------Create Table-------------------

create table Brand
(
ID int primary key identity,
[Name] nvarchar(100)
)

create table Gender
(
ID int primary key identity,
[Name] nvarchar(10)
)

create table [Status]
(
ID int primary key identity,
New bit
)

create table Parfum
(
ID int primary key identity,
[Name] nvarchar(100),
Model nvarchar(100),
BrandID int not null,
GenderID int not null,
StatusID int not null,
foreign key (BrandID) references Brand(ID),
foreign key (GenderID) references Gender(ID),
foreign key (StatusID) references [Status](ID),
Price decimal
)

-----------------------Add Procedure------------------------------

create procedure Add_Parfum
@name nvarchar(100),
@brandId int,
@genderId int,
@statusId int,
@price decimal
as
insert into Parfum([Name],BrandID,GenderID,StatusID,Price) 
values
(@name,@brandId,@genderId,@statusId,@price)

execute Add_Parfum 'Fendi' ,1,1,1,70.2,
execute Add_Parfum 'Agonist' ,2,2,3,50.55,
execute Add_Parfum 'Escada' ,1,3,2,30.79


-------------------Update Procedure-------------------

create procedure UpdateParfum
@name nvarchar(max)=null,
@id int
as
update Parfum set Name=@name where ID=@id 

execute UpdateParfum 'Soel',2

-------------------Delete Procedure----------------------------

create procedure DeleteParfum
@id int
as
delete from Parfum where Id=@id

execute DeleteParfum 2

---------------------ParfumInfo---------------------------------------

create view ParfumInfo as
select Parfum.[Name] 'Name',Brand.[Name] 'Brand',Gender.[Name] 'Gender' from Parfum
join Brand on Parfum.BrandID=Brand.ID
join Gender on Parfum.GenderID=Gender.ID

select * from ParfumInfo


---------------------Sale View-----------------------------

create view SaleInfo as
select Parfum.[Name] 'Name',Parfum.Price 'Price',Gender.[Name] 'Gender',Brand.[Name] 'Brand' from Parfum
join Gender on Parfum.GenderID=Gender.ID
join Brand on Parfum.BrandID=Brand.ID


select *from SaleInfo

-------------------------SearchInfo-------------------------------

create procedure SearchInfo
@search nvarchar(max)=null,
@minsum int,
@maxsum int
as
select Parfum.[Name] 'Name',Parfum.Price 'Price',Brand.[Name] 'Brand',Parfum.Model 'Model' from Parfum
join Brand on Parfum.BrandID=Brand.ID
where Parfum.Price>@minsum and Parfum.Price<@maxsum and
Parfum.[Name] like '%' + ISNULL(@search ,Parfum.[Name])+'%' or
Brand.[Name] like '%' + ISNULL(@search ,Brand.[Name])+'%' or
Parfum.Model like '%' + ISNULL(@search ,Parfum.Model)+'%'

execute SearchInfo 'esca','20','90'
