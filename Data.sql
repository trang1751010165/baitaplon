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
insert dbo.FoodCategory
(Name)
values (N'trà')

insert dbo.FoodCategory
(Name) 
values (N'đồ ăn')

insert dbo.FoodCategory
(Name)
values (N'topping')

insert dbo.Food
(Name,idCategory,price)
values (N'trà sữa truyền thống',
		N'1',
		N'20000')

insert dbo.Food
(Name,idCategory,price)
values (N'trà đào',
		N'1',
		N'30000')

insert dbo.Food
(Name,idCategory,price)
values (N'trà vải',
		N'1',
		N'30000')
insert dbo.Food
(Name,idCategory,price)
values (N'hồng trà',
		N'1',
		N'25000')
insert dbo.Food
(Name,idCategory,price)
values (N'lục trà',
		N'1',
		N'30000')
insert dbo.Food
(Name,idCategory,price)
values (N'bánh mỳ xúc xích',
		N'2',
		N'35000')
insert dbo.Food
(Name,idCategory,price)
values (N'bông lan trứng muối',
		N'2',
		N'10000')
insert dbo.Food
(Name,idCategory,price)
values (N'bánh kem',
		N'2',
		N'40000')
insert dbo.Food
(Name,idCategory,price)
values (N'bánh tiramusu',
		N'2',
		N'37000')
insert dbo.Food
(Name,idCategory,price)
values (N'bánh chesse cake',
		N'2',
		N'40000')
insert dbo.Food
(Name,idCategory,price)
values (N'trân châu trắng',
		N'3',
		N'10000')
insert dbo.Food
(Name,idCategory,price)
values (N'thạch trái cây',
		N'3',
		N'5000')
insert dbo.Food
(Name,idCategory,price)
values (N'kem chesse',
		N'3',
		N'7000')
insert dbo.Food
(Name,idCategory,price)
values (N'trân châu hoàng kim',
		N'3',
		N'8000')
insert dbo.Food
(Name,idCategory,price)
values (N'thạch củ năng',
		N'3',
		N'6000')

create proc usp_FoodList3
as select * From dbo.Food
go
Exec dbo.usp_FoodList3

