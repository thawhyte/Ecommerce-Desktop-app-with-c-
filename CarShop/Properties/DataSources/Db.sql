Create Database Csharp 
create table Registration( 
UserId int IDENTITY Primary key,
FirstName varchar(50) not null,
LastName varchar(50) not null,
Country varchar(100),
State varchar(30),
contact_Address varchar(250) not null,
telephone varchar(20),
username varchar(50) not null,
password varchar(50) not null
)




create table CartDetails(
CartID int Identity Primary key,
Brand varchar(50),
Quantity int,
Price int,
total int,
Image image
)

ALTER TABLE CartDetails
DROP COLUMN total

ALTER TABLE CartDetails
ADD total AS Quantity*Price


truncate table CartDetails
select * from CartDetails