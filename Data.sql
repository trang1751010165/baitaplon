create database QuanLiQuanTraSua
go
use QuanLiQuanTraSua
go
create table Acount
(
	DisplayName NVARCHAR (100) not null default N'Kter',
	UserName NVARCHAR(100) primary key,
	PassWorld NVARCHAR(1000)not null default 0,
	Type INT not null default 0
)
go
create table FoodCategory
(
	id int identity primary key,
	Name NVARCHAR (100) not null default N'chưa đặt tên'
)
go
create table Food
(
	id int identity primary key,
	Name NVARCHAR (100) not null default N'chưa đặt tên',
	idCategory int not null,
	price float not null default 0
	foreign key (idCategory) references dbo.FoodCategory(id)
)
go
--create table Bill
--(
	--id int identity primary key,
	--status int not null default 0
--)
--go
create table BillInfo
(
	id int identity primary key,
	idBill int not null,
	idFood int not null,
	count int not null default 0
	foreign key (idFood) references dbo.Food(id)
)
go
insert into dbo.Acount
(
	DisplayName,
	UserName,
	PassWorld,
	Type
)
values (N'trang',
		N'nguyentrang',
		N'1',
		1
)
go
insert into dbo.Acount
(
	DisplayName,
	UserName,
	PassWorld,
	Type
)
values (N'staff',
		N'staff',
		N'1',
		0
)
go
create proc usp_GetAcountByUserName
@userName nvarchar(100)
as
begin
	select * from dbo.Acount where UserName=@userName
end
go
Exec dbo.usp_GetAcountByUserName @userName=N'nguyentrang'
go

--select * from dbo.Acount where UserName=N'nguyentrang' and PassWorld=N'1'

create proc usp_Login
@userName nvarchar(100),@passWord nvarchar(100)
as
begin
	select * from dbo.Acount where UserName=@userName and PassWorld=@passWord
end
go




