CREATE DATABASE QuanLyKatinat
GO
USE	QuanLyKatinat
GO

--Food
--Table
--FoodCategory
--Account
--Bill
--BillInfo 

CREATE TABLE TableFood
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	[name] NVARCHAR(100) NOT NULL DEFAULT N'Chưa có tên',
	[status] NVARCHAR(100)  NOT NULL DEFAULT N'Trống'
)
GO
CREATE TABLE Account
(
    UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'A',	
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0
)
GO
CREATE TABLE FoodCategory
(   
    id INT IDENTITY(1,1) PRIMARY KEY,
	[name] NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO
CREATE TABLE Food
(
    id INT IDENTITY(1,1) PRIMARY KEY,
	[name] NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL default 0,
	num int NOT NULL default 0
	foreign key (idCategory) references dbo.FoodCategory(id)
)
GO
CREATE TABLE ShippingOrder
(
    id INT IDENTITY(1,1) PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE NOT NULL,
	status int NOT NULL,
	idRequest NVARCHAR(100) NOT NULL,
	idConfirm NVARCHAR(100) NULL,
    foreign key (idRequest) references dbo.Account(UserName),
	foreign key (idConfirm) references dbo.Account(UserName)

    
)
GO
CREATE TABLE ShippingOrderNotes
(
    id INT IDENTITY(1, 1) PRIMARY KEY,
    idShippingOrder INT NOT NULL,
    Note NVARCHAR(500) NOT NULL,
    NoteDate DATE NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (idShippingOrder) REFERENCES dbo.ShippingOrder(id)
)
CREATE TABLE Food_ShippingOrder
(
	id int identity(1,1) PRIMARY KEY,
	idShippingOrder INT NOT NULL,
	idFood INT NOT NULL,
	num INT NOT NULL DEFAULT 1
	foreign key (idShippingOrder) references dbo.ShippingOrder,
	foreign key (idFood) references dbo.Food



)

CREATE TABLE Bill
(
    id INT IDENTITY(1,1) PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE NOT NULL,
	idTable INT NOT NULL,
	status INT NOT NULL, --1:đã thanh toán 0:chưa thanh toán
	Total float,
	idAccount NVARCHAR(100) NOT NULL
	foreign key (idAccount) references dbo.Account(UserName),
	foreign key (idTable) references dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo
(
	id int identity(1,1) primary key,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count int not null default 0

	foreign key (idBill) references dbo.Bill(id),
	foreign key (idFood) references dbo.Food(id)
)
GO
INSERT INTO dbo.Account VALUES
( N'Vietbl',N'Việt Bùi','123',1)
INSERT INTO dbo.Account VALUES
( N'Staff',N'Staff','123',0)
INSERT INTO dbo.Account VALUES
( N'Shipper',N'Shipper','123',2)


insert into TableFood VALUES
('TABLE 1','Empty')
insert into TableFood VALUES
('TABLE 2','Empty')

insert into TableFood VALUES
('TABLE 3','Empty')

insert into TableFood VALUES
('TABLE 4','Empty')

insert into TableFood VALUES
('TABLE 5','Empty')

insert into TableFood VALUES
('TABLE 6','Empty')

insert into TableFood VALUES
('TABLE 7','Empty')

insert into TableFood VALUES
('TABLE 8','Empty')
insert into TableFood VALUES
('TABLE 9','Empty')

insert into FoodCategory values
('Espresso classics')
insert into FoodCategory values
('Traditional coffee')
insert into FoodCategory values
('Ice blended')
insert into FoodCategory values
('Milk tea')
insert into FoodCategory values
('Fruit tea')
insert into FoodCategory values
('Macchiato')
insert into FoodCategory values
('Chocolate')
insert into FoodCategory values
('Refresh drink')
insert into FoodCategory values
('Smoothie Yogurt')


