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