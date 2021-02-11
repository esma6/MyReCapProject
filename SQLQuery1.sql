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

INSERT INTO Brands(BrandName) Values('Mercedes'),('BMW'),('Volkswagen'),('Toyota'),('Volvo');
INSERT INTO Colors(ColorName) Values('Beyaz'),('Siyah'),('Gri'),('Mavi'),('Kırmızı');
INSERT INTO Cars(BrandId,ColorId,CarName,ModelYear,DailyPrice,Description)
Values
('1','2','CLA','2019','150','Benzin'),
('2','3','X5','2020','200','Benzin'),
('3','1','Jetta','2018','100','Dizel'),
('4','3','C-HR','2019','150','Hibrit'),
('5','5','S90','2018','150','Benzin');

select * from Cars