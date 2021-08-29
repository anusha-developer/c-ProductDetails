Create  database  Onlinesort
CREATE TABLE ProductCategory(
    Id int,
    Name varchar(100),
    IsActive bit);
insert into ProductCategory (Id, Name, IsActive)
VALUES (1,'Fashion',1);
insert into ProductCategory (Id, Name, IsActive)
VALUES (2,'Electronics',1);
insert into ProductCategory (Id, Name, IsActive)
VALUES (3,'Kitchen',1);
insert into ProductCategory (Id, Name, IsActive)
VALUES (4,'Vehicles',1);
Select * from ProductCategory

CREATE TABLE ProductSubCategory(
    Id int,
    Name varchar(100),
    maincategoryId int);

select * from ProductSubCategory
insert into ProductSubCategory (Id, Name, maincategoryId)
VALUES (1,'Women',1);
insert into ProductSubCategory (Id, Name, maincategoryId)
VALUES (2,'Mens',2);
insert into ProductSubCategory (Id, Name, maincategoryId)
VALUES (3,'Kids',2);

CREATE TABLE ProductAccessories(
    Id int,
     ProductAccessories varchar(100));
insert into ProductAccessories (Id,ProductAccessories )
VALUES (1,'Charger');
insert into ProductAccessories (Id,ProductAccessories )
VALUES (2,'Bag');
insert into ProductAccessories (Id,ProductAccessories )
VALUES (3,'Headset');
insert into ProductAccessories (Id,ProductAccessories )
VALUES (4,'Screensaver');
insert into ProductAccessories (Id,ProductAccessories )
VALUES (5,'Warrenty');

select * from  ProductAccessories

CREATE TABLE ProductDetails(
    Id int,
     ProductDetails varchar(100));
insert into ProductDetails (Id,ProductDetails )
VALUES (1,'Productname');
insert into ProductDetails (Id,ProductDetails )
VALUES (2,'Productmodel');
insert into ProductDetails (Id,ProductDetails )
VALUES (3,'Displaysize');
insert into ProductDetails (Id,ProductDetails )
VALUES (4,'Price');
insert into ProductDetails (Id,ProductDetails )
VALUES (5,'Discount');
insert into ProductDetails (Id,ProductDetails )
VALUES (6,'Final price');

select * from  ProductDetails

CREATE TABLE ProductSoftwares(
    Id int,
     Productsoftwares varchar(100));
	 insert into ProductSoftwares (Id,ProductSoftwares )
VALUES (1,'Antivirus');
	 insert into ProductSoftwares (Id,ProductSoftwares )
VALUES (2,'Msoffice');
select * from ProductSoftwares

CREATE TABLE ProductFeatures(
    Id int,
     Productfeatures varchar(100));
 insert into Productfeatures (Id,Productfeatures )
VALUES (1,'Camera');
 insert into Productfeatures (Id,Productfeatures )
VALUES (2,'Ram');
 insert into Productfeatures (Id,Productfeatures )
VALUES (3,'Rom');
insert into Productfeatures (Id,Productfeatures )
VALUES (4,'Os');
 insert into Productfeatures (Id,Productfeatures )
VALUES (5,'Batterybackup');
insert into Productfeatures (Id,Productfeatures )
VALUES (6,'Processor');
 insert into Productfeatures (Id,Productfeatures )
VALUES (7,'Clockspeed');
insert into Productfeatures (Id,Productfeatures )
VALUES (8,'Graphicalspeed');
 insert into Productfeatures (Id,Productfeatures )
VALUES (9,'fingerprint');
insert into Productfeatures (Id,Productfeatures )
VALUES (10,'Touchscreen');
 insert into Productfeatures (Id,Productfeatures )
VALUES (11,'HDMA');
insert into Productfeatures (Id,Productfeatures )
VALUES (12,'Audio');
 insert into Productfeatures (Id,Productfeatures )
VALUES (13,'Usbport');

select * from ProductFeatures