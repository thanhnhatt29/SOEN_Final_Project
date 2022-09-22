create database FASTFOOD
go

use FASTFOOD
go

create table EMPLOYEE(
	employee_id char(10) primary key,
	employee_name nvarchar(100),
	phone_number char(10) null,
	gender bit not null,
	position nvarchar(20)	
)
go

create table ACCOUNT(
	employee_id char(10) references EMPLOYEE(employee_id),
	passwd char(10) not null,
	permission bit,
	primary key(employee_id)
)
go



create table PRODUCT(
	product_id int identity(1,1) primary key,
	product_name nvarchar(50) not null,
	price float constraint check_price check(price>=0) not null,
	update_date datetime not null,
	detail nvarchar(50) null
)
go

create table VOUCHER(
	voucher_id char(10) primary key,
	apply_price float constraint min_money check (apply_price>=0) not null,
	off_percent int constraint percent_off check (off_percent>=0 and off_percent<=50),
	--off_money float constraint max_sales check(off_money<=100000),
	used bit,
)
go

create table BILL(
	bill_id char(10) primary key,
	date_created datetime not null,
	employee_id char(10) references EMPLOYEE(employee_id)not null,
	voucher_id char(10) references VOUCHER(voucher_id) null,
	bill_price float constraint check_bill_price check(bill_price>=0),
	off_money float constraint check_final_money check (off_money>=0),
)
go

create table BILL_DETAIL(
	bill_id char(10) references BILL(bill_id),
	product_id int references PRODUCT(product_id),
	amount int constraint check_amount_detail check(amount>0),
	primary key(bill_id,product_id)
)
go


--Add
create proc add_Employee
	@id char(10),
	@name nvarchar(100),
	@phone char(10),
	@sex bit,
	@position nvarchar(20)
as
	insert into EMPLOYEE(employee_id,employee_name,phone_number,gender,position)
	values (@id,@name,@phone,@sex,@position)
go

create proc add_Product
	@name nvarchar(50),
	@price float,
	@update_date datetime,
	@detail nvarchar(50)
as 
	insert into PRODUCT(product_name,price,update_date,detail)
	values (@name,@price,@update_date,@detail)
go

create proc add_Voucher
	@id char(10),
	@apply_price float,
	@percent float
as
	insert into VOUCHER(voucher_id,apply_price,off_percent,used)
	values (@id,@apply_price,@percent, 0)
go

create proc add_Bill
	@bill_id char(10),
	@date datetime,
	@employee_id char(10),
	@voucher_id char(10)
as
	insert into BILL(bill_id,date_created,employee_id,voucher_id,bill_price,off_money)
	values (@bill_id,@date,@employee_id,@voucher_id,0,0)
go

create proc add_Bill_detail
	@bill_id char(10),
	@product_id int,
	@amount int
as
	insert into BILL_DETAIL(bill_id,product_id,amount)
	values(@bill_id,@product_id,@amount)
go

create proc add_Account
	@id char(10),
	@pass char(10),
	@permit bit
as
	insert into ACCOUNT(employee_id,passwd,permission)
	values (@id,@pass,@permit)
go

--Update
create proc update_Bill
	@id char(10)
as 
	--declare @off_money float=(select off_money from VOUCHER where voucher_id=(select voucher_id from BILL where bill_id=@id))
	update BILL
	set bill_price=(select sum(amount*price) from (select bd.amount,p.price from BILL_DETAIL bd join PRODUCT p on bd.product_id=p.product_id where bill_id=@id)as Q1),
		off_money=((select sum(amount*price) from (select bd.amount,p.price from BILL_DETAIL bd join PRODUCT p on bd.product_id=p.product_id where bill_id=@id)as Q1)*(select off_percent from VOUCHER where voucher_id= (select voucher_id from BILL where bill_id=@id))/100)
	where bill_id=@id

go

/*
create proc update_Bill_Detail
	@id char(10)
as
	update BILL_DETAIL
	set price = (select price from PRODUCT where PRODUCT.product_id=BILL_DETAIL.product_id)
	where bill_id=@id
go
*/


create proc update_Product
	@id int,
	@name nvarchar(50),
	@price float,
	@date datetime,
	@detail nvarchar(50)
as
	update PRODUCT
	set product_name=@name, price=@price,update_date=@date,detail=@detail
	where product_id=@id
go


create proc update_Voucher_Used
	@id char(10)
as
	update VOUCHER
	set used=1
	where voucher_id=@id
go

create proc update_Employee
	@id char(10),
	@name nvarchar(100),
	@phone char(10),
	@position nvarchar(20)
as
	update EMPLOYEE
	set employee_name=@name, phone_number=@phone, position=@position
	where employee_id=@id
go




--Delete


--get data

--Doanh thu theo ngay
create function Revenue_Day
(@date datetime)
returns float
as
begin 
	declare @revenue float
	set @revenue=(select sum(bill_price*off_money) from BILL b where DAY(b.date_created)=DAY(@date) and MONTH(b.date_created)=MONTH(@date) and YEAR(b.date_created)=YEAR(@date))
	return @revenue
end
go

--Doanh thu theo thang
create function Revenue_Month
(@date datetime)
returns float
as
begin
	declare @revenue float
	set @revenue=(select sum(bill_price*off_money) from BILL b where MONTH(b.date_created)=MONTH(@date) and YEAR(b.date_created)=YEAR(@date))
	return @revenue
end
go

