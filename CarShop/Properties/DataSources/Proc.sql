alter PROC UserAdd
@FirstName varchar(20) ,
@LastName varchar(20),
@Country varchar(20),
@state varchar(20),
@contact_Address varchar(20),
@telephone varchar(20),
@username varchar(20),
@password varchar(20)

AS
	INSERT INTO Registration(FirstName,LastName,Country,state,contact_Address,telephone,username,password)

	VALUES(@FirstName,@LastName,@Country,@state,@contact_Address,@telephone,@username,@password)


---Cart Procedure----



alter Proc CartDetailsProc
@Brand varchar(50),
@Quantity int,
@Price int,
@Image image

AS
	INSERT INTO CartDetails(Brand,Quantity,Price,Image)
	VALUES(@Brand,@Quantity,@Price,@Image)

