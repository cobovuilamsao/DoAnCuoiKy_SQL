CREATE DATABASE Coffee_Shop_Management_Software
GO

USE Coffee_Shop_Management_Software
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo
go
-----------------------------------------create table
CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Avral',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO
create TABLE TableFood (

	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Table hasnt existed name',
	status NVARCHAR(100) NOT NULL DEFAULT N'Empty',	-- empty|| having people 
	Username nvarchar(100)
	)
GO
alter table TableFood add constraint Account_forgeinkey foreign key (UserName) REFERENCES Account(UserName);

SELECT * FROM TABLEFOOD

CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Avral',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO
CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Name havent set name'
)
GO
CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Name havent set name',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO
CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	statuses int NOT NULL DEFAULT 0, -- 1: paid && 0: havent paid
	grosslycost float,
	Discount int default 0 
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO
CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO
--------------------------------------------create table

-------------------------------------------------Insert
insert into dbo.Account(
	UserName ,
	DisplayName, 
	PassWord ,
	Type 
)
values(
N'K9',
N'Rong K9',
N'1',
1
)
go
insert into dbo.Account(
	UserName ,
	DisplayName, 
	PassWord ,
	Type 
)
values(
N'Staff',
N'Staff',
N'1',
0
)

--select * from Account
-- inserting category of food 
insert FoodCategory (name)values(N'SeaFood')--55
insert FoodCategory (name)values(N'Farmfood')--56
insert FoodCategory (name)values(N'HomeFood')--57
--insert FoodCategory (name)values(N'StreetFood')--4
insert FoodCategory (name)values(N'FrogFood')--58
insert FoodCategory (name)values(N'FishFood')--59
insert FoodCategory (name)values(N'CowFood')--60
--insert FoodCategory (name)values(N'BuffalowFood')--8
insert FoodCategory (name)values(N'FruitFood')--61
insert FoodCategory (name)values(N'DrinkingFood')--62

select * from foodcategory
go
--inserting name of food 
insert Food (name ,idCategory,price)values(N'Sá sùng',1,4000000)
insert Food (name ,idCategory,price)values(N'Bào ngư',1,1200000)
insert Food (name ,idCategory,price)values(N'Cua huỳnh đế',1,1000000)
insert Food (name ,idCategory,price)values(N'Tôm hùm',1,1200000)
insert Food (name ,idCategory,price)values(N'Tôm mũ ni đỏ',1,2000000)

insert Food (name ,idCategory,price)values(N'CÁ BỐNG ĐỤC KHO LÁ CHÈ XANH',2,800000)
insert Food (name ,idCategory,price)values(N'BÒ XÀO BÓNG HÀNH',2,500000)

insert Food (name ,idCategory,price)values(N'LÒNG HEO XÀO DỨA (THƠM)',3,400)
insert Food (name ,idCategory,price)values(N'THỊT XIÊN NƯỚNG',3,200000)
insert Food (name ,idCategory,price)values(N'Sườn nướng giấy bạc thơm ngon khó cưỡng',3,500000)

insert Food (name ,idCategory,price)values(N'Ếch chiên bơ',4,90000)
insert Food (name ,idCategory,price)values(N'Ếch chiên mè',4,50000)
insert Food (name ,idCategory,price)values(N'Ếch xào hành tỏi',4,30000)
insert Food (name ,idCategory,price)values(N'Ếch xào tía tô',4,35000)

insert Food (name ,idCategory,price)values(N'Ngọt mềm thịt bò nướng kiểu Hàn Quốc',6,90000)
insert Food (name ,idCategory,price)values(N' Gỏi sấu, thịt bò',6,50000)
insert Food (name ,idCategory,price)values(N'Xuýt xoa thịt bò nấu dưa chua',6,30000)
insert Food (name ,idCategory,price)values(N'Súp thịt bò rau củ ngon lành cho bữa sáng',6,35000)

insert Food (name ,idCategory,price)values(N'Cá kho dưa',5,20000)
insert Food (name ,idCategory,price)values(N'Cá hồi nướng tiêu chanh',5,15000)
insert Food (name ,idCategory,price)values(N'Ruốc cá hồi',5,25000)
insert Food (name ,idCategory,price)values(N'Chả cá, đậu phụ rán giòn',5,35000)

insert Food (name ,idCategory,price)values(N'Soda',7,15000)
insert Food (name ,idCategory,price)values(N'choka',7,20000)
insert Food (name ,idCategory,price)values('Coffee',8,15000)
insert Food (name ,idCategory,price)values(N'Sting',8,12000)
insert Food (name ,idCategory,price)values(N'Trà Đào',7,11000)
insert Food (name ,idCategory,price)values(N'bubble tea',7,16000)


go
----------------------------------------------------Insert

----------------------------------------------Procedure
go
create procedure Avral_GetaccountbyUsername 
@Username NVARCHAR(100)
as
begin
select * from Account where @UserName=dbo.Account.UserName
end
go
declare @i int =0
while @i<50
begin
insert dbo.TableFood(name,status)values(N'No.'+ cast(@i as  NVARCHAR(100)),'Empty')
set @i=@i+1
end
go
--creating procedure 
go 
create procedure USP_Getdatatable
as select * from TableFood
go
create procedure updateexist
as

Update TableFood set status = N'existed'
from TableFood t1 inner join Bill t2 on t1.id = t2.idTable 

 go
 create procedure GetuncheckIDbyTableID
 @Idtable int 
 as
begin
select * from dbo.Bill where dbo.Bill.idTable=@Idtable 
 end


 go


 go
create procedure Insert_bill
@idTable int
as 
begin
insert Bill (DateCheckIn,DateCheckOut,idTable,statuses,Discount)values(GETDATE(),NULL,@idTable,0,0)
end 
go
create procedure Insert_billinfor
@idbill int , @idfood int , @count int
as 
begin
	declare @isexistbillinfor int 
	declare @foodcount int =1

	select @isexistbillinfor=id, @foodcount=b.count 
	from dbo.BillInfo as b 
	where idBill=@idbill and idFood=@idfood
		if(@isexistbillinfor>0)
			begin
				declare @newcount int = @foodcount+@count
				if(@newcount>0)
				update dbo.BillInfo set count =@foodcount+@count where idfood=@idfood
				else
				delete dbo.BillInfo where idBill=@idbill and idFood=@idfood 
			end
		else
			begin
			insert BillInfo (idBill,idFood,count)
			values(@idbill ,@idfood,@count)
			end
end




go
--update table exist when we table doesn't exest in bill and billinfor  (the first way )
go
create procedure UpdatestatusTable
as
	begin
		update TableFood set status=N'Existed'
		WHERE EXISTS (SELECT TableFood.id, Bill.idTable FROM Bill,BillInfo ,Food WHERE Bill.idTable=TableFood.id and bill.id=BillInfo.idBill and BillInfo.idFood=Food.id)
		update TableFood set status=N'Empty'
		WHERE NOT EXISTS (SELECT TableFood.id, Bill.idTable FROM Bill ,BillInfo, Food where Bill.idTable=TableFood.id and bill.id=BillInfo.idBill and BillInfo.idFood=Food.id)

	end


-
--using trgger in order to do this task specially billinfor table 
go
create trigger UpdateforBillinfo
ON BillInfo for insert,update
-- "ON" which one of table you want task
-- "FOR" what case for? for instance insert and update
as
begin
 declare @idbill int 
 select @idbill=idbill from inserted

 declare @idtable int 
 select @idtable=idtable from dbo.Bill where id=@idbill and statuses=0

 update dbo.TableFood set status=N'Existed' where id=@idtable
end  
go
-- creating the second trigger for updatebill
create trigger Updatebill
on dbo.Bill for update
as 
begin
declare @idbill int 
select @idbill=id from inserted 
declare @idtable int
select @idtable =idtable from dbo.Bill where id=@idbill
declare @count int =0
select @count=COUNT(*) from dbo.Bill where idTable=@idtable and statuses=0
if(@count=0)
update dbo.TableFood set status =N'Empty' where id=@idtable;
end
go

go
create procedure profitbyday
@daycheckin date,@daycheckout date
as 
begin
	select a.name, a.id as N'key-table', datecheckin,datecheckout, discount, sum(b.Grosslycost) as Grosslycost
	from tablefood as a ,bill as b 
	where b.datecheckin>=@daycheckin and b.datecheckout<=@daycheckout and b.statuses=1  
	and a.id=b.idtable
	group by a.name,a.id,datecheckin,datecheckout, discount
end
go
create Procedure Updateaccount
@username nvarchar(100), @displayname nvarchar(100),@password nvarchar(100),@newpassword nvarchar(100)
as 
begin

declare @isrightpass int =0
select @isrightpass=count(*) from Account where Account.UserName=@username and Account.PassWord=@password 
 if(@isrightpass=1)
 begin
		if(@newpassword=null or @newpassword='')
		begin 
		update dbo.Account set DisPlayName=@displayname where UserName=@username
		end  
		else 
		update dbo.Account set DisPlayName=@displayname, PassWord=@newpassword where UserName=@username

 end 

end 
go 
create trigger deletebillinfo
on billinfo for delete
as 
begin
 declare @idbillinfo int
 declare @idbill int 
 select @idbillinfo=id,@idbill=deleted.idbill from  deleted

declare @idtable int 
select @idtable=idtable from bill where id=@idbill

--we need to bring out the count 
declare @count int=0
select @count=COUNT(*) from billinfo as bi,bill as b where b.id=bi.idbill and b.id=@idbill and statuses=0

if(@count=0)
update tablefood set status=N'Empty' where id=@idtable
end 
go
-- function for seeking VietNamese or English or anyelse
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000)
AS 
BEGIN 
IF @strInput IS NULL 
RETURN @strInput 
IF @strInput = '' 
RETURN @strInput 
DECLARE @RT NVARCHAR(4000) 
DECLARE @SIGN_CHARS NCHAR(136) 
DECLARE @UNSIGN_CHARS NCHAR (136) 
SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
DECLARE @COUNTER int 
DECLARE @COUNTER1 int 
SET @COUNTER = 1 
WHILE (@COUNTER <=LEN(@strInput)) 
BEGIN SET @COUNTER1 = 1 
WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
BEGIN 
IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
BEGIN 
IF @COUNTER=1 
SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
ELSE 
SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) 
BREAK 
END 
SET @COUNTER1 = @COUNTER1 +1 
END SET @COUNTER = @COUNTER +1 
END SET @strInput = replace(@strInput,' ','-') 
RETURN @strInput 
END
 --select * from Dbo.food where [dbo].[fuConvertToUnsign1](name) like N'%'+[dbo].[fuConvertToUnsign1](N'sa')+'%'
go
create procedure CheckOutSQL
@sumfood int,@idtable int, @UserName nvarchar(100)
as
begin 
select  top(@sumfood) b.id, a.name , a.id  , datecheckin,datecheckout,d.name as food_name ,d.price, discount,  Grosslycost ,c.count ,e.UserName 
from tablefood as a ,bill as b ,billinfo as c, food as d,account as e
where e.Username=@UserName and e.username=a.UserName and  b.statuses=1 and a.id=@idtable  and b.id=c.idBill and c.idFood=d.id 
ORDER BY  b.id  desc 
end

create procedure CheckOutSQL_pro
@sumfood int,@idtable int
as
begin 
select  top(@sumfood) b.id, a.name , a.id  , datecheckin,datecheckout,d.name as food_name ,d.price, discount,  Grosslycost ,c.count ,e.UserName 
from tablefood as a ,bill as b ,billinfo as c, food as d,account as e
where  b.statuses=1 and a.id=@idtable  and b.id=c.idBill and c.idFood=d.id  and e.username=a.username
ORDER BY  b.id  desc 
end

create procedure updateusername
@username nvarchar(100),@idtable int
as 
begin 

IF EXISTS(SELECT id,username FROM tablefood WHERE id=@idtable and status=N'Empty')
	BEGIN
	update tablefood set UserName=N'@username',status=N'Existed' where id=@idtable
	END
ELSE
	BEGIN
	print 'you cannot touch with this table'
	END
end

go
create procedure movingtable
@idtableold int,@statusold Nvarchar(100), @idtablenew int ,@statusnew Nvarchar(100)
as
begin
update bill set idtable=@idtablenew where idtable=@idtableold
update tablefood set tablefood.id=@idtablenew , status=@statusnew where tablefood.id=@idtableold
update tablefood set tablefood.id=@idtableold , status=@statusold where tablefood.id=@idtablenew
end 




--how table movement
go
create PROC USP_SwitchTabel
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND statuses = 0
	
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND statuses = 0
	
	
	
	IF (@idFirstBill IS NULL)
	BEGIN
	
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          statuses
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND statuses = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill

	
	IF (@idSeconrdBill IS NULL)
	BEGIN

		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          statuses
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND statuses = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	


	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idFirstBill
	
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Empty' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Empty' WHERE id = @idTable1
END
GO
create PROC Combiningtable
@idTable1 INT, @idTable2 int
AS BEGIN

	DECLARE @idFirstBill int
	DECLARE @idSeconrdBill INT
	
	DECLARE @isFirstTablEmty INT = 1
	DECLARE @isSecondTablEmty INT = 1
	
	
	SELECT @idSeconrdBill = id FROM dbo.Bill WHERE idTable = @idTable2 AND statuses = 0
	
	SELECT @idFirstBill = id FROM dbo.Bill WHERE idTable = @idTable1 AND statuses = 0
	
	
	
	IF (@idFirstBill IS NULL)
	BEGIN
	
		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          statuses
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable1 , -- idTable - int
		          0  -- status - int
		        )
		        
		SELECT @idFirstBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable1 AND statuses = 0
		
	END
	
	SELECT @isFirstTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idFirstBill

	
	IF (@idSeconrdBill IS NULL)
	BEGIN

		INSERT dbo.Bill
		        ( DateCheckIn ,
		          DateCheckOut ,
		          idTable ,
		          statuses
		        )
		VALUES  ( GETDATE() , -- DateCheckIn - date
		          NULL , -- DateCheckOut - date
		          @idTable2 , -- idTable - int
		          0  -- status - int
		        )
		SELECT @idSeconrdBill = MAX(id) FROM dbo.Bill WHERE idTable = @idTable2 AND statuses = 0
		
	END
	
	SELECT @isSecondTablEmty = COUNT(*) FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	


	SELECT id INTO IDBillInfoTable FROM dbo.BillInfo WHERE idBill = @idSeconrdBill
	UPDATE dbo.BillInfo SET idBill = @idFirstBill WHERE id IN (SELECT * FROM IDBillInfoTable)
	UPDATE dbo.BillInfo SET idBill = @idSeconrdBill WHERE idBill = @idSeconrdBill
	

	
	DROP TABLE IDBillInfoTable
	
	IF (@isFirstTablEmty = 0)
		UPDATE dbo.TableFood SET status = N'Empty' WHERE id = @idTable2
		
	IF (@isSecondTablEmty= 0)
		UPDATE dbo.TableFood SET status = N'Empty' WHERE id = @idTable1


	execute UpdatestatusTable
END

GO

delete BillInfo
delete bill
delete tablefood