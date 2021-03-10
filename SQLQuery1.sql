create table Colors(
ColorId int primary key identity(1,1),
ColorName nvarchar(20)
)

create table Brands(
BrandId int primary key identity(1,1),
BrandName nvarchar(20)
)

create table Cars(
CarId int primary key identity(1,1),
BrandId int,
ColorId int,
CarName nvarchar(20),
ModelYear nvarchar(20),
DailyPrice decimal,
Description nvarchar(50),
FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
FOREIGN KEY (ColorId) REFERENCES Colors(ColorId)
)
CREATE TABLE UserOperationClaims(
Id int PRIMARY KEY IDENTITY(1,1),
UserId int,
OperationClaimId int,
FOREIGN KEY (UserId) REFERENCES Users(Id),
FOREIGN KEY (OperationClaimId) REFERENCES OperationClaims(Id)
)

CREATE TABLE Customers(
	Id int PRIMARY KEY IDENTITY(1,1),
	UserId int,
	CompanyName nvarchar(50),
	FOREIGN KEY (UserId) REFERENCES Users(Id)
)


CREATE TABLE Rentals(
	Id int PRIMARY KEY IDENTITY(1,1),
	CarId int,
	CustomerId int,
	RentDate datetime,
	ReturnDate datetime,
	FOREIGN KEY (CarId) REFERENCES Cars(CarId),
	FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
)
CREATE TABLE CarImages(
Id int PRIMARY KEY IDENTITY(1,1),
CarId int,
ImagePath varchar(MAX),
Date datetime,
FOREIGN KEY (CarId) REFERENCES Cars(CarId)
)

SELECT* FROM Customers
select * from Cars

INSERT INTO Users(FirstName,LastName,Email,Password) Values('Esma','Karagülle','ek@gmail.com','123');
INSERT INTO Users(FirstName,LastName,Email,Password) Values('Engin','Demiroğ','ed@gmail.com','321');
INSERT INTO Customers(UserId,CompanyName)VALUES('1','Esma limited şirketi');
INSERT INTO Rentals(CarId,CustomerId,RentDate,ReturnDate) VALUES('1','1','2020-01-03 17:30:00','2020-10-03 12:30:00');
INSERT INTO Brands(BrandName) Values('Mercedes'),('BMW'),('Volkswagen'),('Toyota'),('Volvo');
INSERT INTO Colors(ColorName) Values('Beyaz'),('Siyah'),('Gri'),('Mavi'),('Kırmızı');
INSERT INTO Cars(BrandId,ColorId,CarName,ModelYear,DailyPrice,Description)
Values
('1','2','CLA','2019','150','Benzin'),
('2','3','X5','2020','200','Benzin'),
('3','1','Jetta','2018','100','Dizel'),
('4','3','C-HR','2019','150','Hibrit'),
('5','5','S90','2018','150','Benzin');


