create database FASTFOOD
go

use FASTFOOD
go

create table EMPLOYEE(
	employee_id varchar(6) primary key,
	employee_name nvarchar(100),
	employee_img image null,
	phone_number varchar(10) null,
	birth date,
	gender bit not null,
	position nvarchar(20)	
)
go

create table ACCOUNT(
	employee_id varchar(6) references EMPLOYEE(employee_id),
	passwd varchar(10) not null,
	permission bit,
	primary key(employee_id)
)
go



create table PRODUCT(
	product_id int identity(1,1) primary key,
	product_name nvarchar(50) not null,
	product_img image null,
	price int constraint check_price check(price>=0) not null,
	update_date datetime not null,
	detail nvarchar(50) null
)
go

create table VOUCHER(
	voucher_id varchar(10) primary key,
	apply_price int constraint min_money check (apply_price>=0) not null,
	off_percent int constraint percent_off check (off_percent>=0 and off_percent<=50),
	max_money float constraint max_money check(max_money<=100000),
	used bit,
)
go

create table BILL(
	bill_id varchar(10) primary key,
	date_created datetime not null,
	employee_id varchar(6) references EMPLOYEE(employee_id)not null,
	voucher_id varchar(10) references VOUCHER(voucher_id) on Delete set null,
	bill_price int constraint check_bill_price check(bill_price>=0),
	off_money int constraint check_final_money check (off_money>=0),
	total_money int constraint check_total_money check (total_money>=0),
)
go

create table BILL_DETAIL(
	bill_id varchar(10) references BILL(bill_id),
	product_id int references PRODUCT(product_id),
	amount int constraint check_amount_detail check(amount>0),
	primary key(bill_id,product_id)
)
go

-- For insert sql file
--Add
create proc add_Employee
	@id varchar(10),
	@name nvarchar(100),
	@image image,
	@phone char(10),
	@birth date,
	@sex bit,
	@position nvarchar(20)
as
	insert into EMPLOYEE(employee_id,employee_name,employee_img,phone_number,birth,gender,position)
	values (@id,@name,@image,@phone,@birth,@sex,@position)
go

create proc add_Product
	@name nvarchar(50),
	@image image,
	@price int,
	@update_date datetime,
	@detail nvarchar(50)
	
as 
	insert into PRODUCT(product_name,product_img,price,update_date,detail) 
	values (@name,@image,@price,@update_date,@detail)
go

create proc add_Voucher
	@id varchar(10),
	@apply_price int,
	@percent float
as
	insert into VOUCHER(voucher_id,apply_price,off_percent,used)
	values (@id,@apply_price,@percent, 0)
go

create proc add_Bill
	@bill_id varchar(10),
	@date datetime,
	@employee_id varchar(10),
	@voucher_id varchar(10)
as
	insert into BILL(bill_id,date_created,employee_id,voucher_id,bill_price,off_money)
	values (@bill_id,@date,@employee_id,@voucher_id,0,0)
go

create proc add_Bill_detail
	@bill_id varchar(10),
	@product_id int,
	@amount int
as
	insert into BILL_DETAIL(bill_id,product_id,amount)
	values(@bill_id,@product_id,@amount)
go

create proc add_Account
	@id varchar(10),
	@pass varchar(10),
	@permit bit
as
	insert into ACCOUNT(employee_id,passwd,permission)
	values (@id,@pass,@permit)
go

--Update


create proc update_Bill
	@id varchar(10)
as 
	declare @off_money int=((select sum(amount*price) from (select bd.amount,p.price from BILL_DETAIL bd join PRODUCT p on bd.product_id=p.product_id where bill_id=@id)as Q1)*(select off_percent from VOUCHER where voucher_id= (select voucher_id from BILL where bill_id=@id))/100),
			@bill_price int=(select sum(amount*price) from (select bd.amount,p.price from BILL_DETAIL bd join PRODUCT p on bd.product_id=p.product_id where bill_id=@id)as Q1)
	update BILL
	set bill_price=@bill_price,
		off_money=@off_money,
		total_money=@bill_price-@off_money
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
	@image image,
	@price float,
	@date datetime,
	@detail nvarchar(50)
as
	update PRODUCT
	set product_name=@name, price=@price,update_date=@date,detail=@detail,product_img=@image
	where product_id=@id
go


create proc update_Voucher_Used
	@id varchar(10)
as
	update VOUCHER
	set used=1
	where voucher_id=@id
go

create proc update_Employee
	@id varchar(10),
	@name nvarchar(100),
	@image image,
	@phone varchar(10),
	@position nvarchar(20)
as
	update EMPLOYEE
	set employee_name=@name, phone_number=@phone, position=@position,employee_img=@image
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



insert into PRODUCT(product_name,product_img,price,update_date,detail)
values
(N'Cà phê',null,20000,'2000-2-2', N'Không có'),
(N'Gà chiên',null,50000,'2000-2-2',N'Không có'),
(N'CocaCola',null,10000,'2000-2-2',N'Không có'),
(N'Cơm trưa',null,30000,'2022-9-17',N'Không có'),
(N'Cà phê sữa',null,25000,'2022-11-1',N'Không có'),
(N'Kem dâu',null,25000,'2022-11-1',N'Không có'),
(N'Kem socola',null,25000,'2022-11-1',N'Không có'),
(N'Bạc xỉu',null,25000,'2022-11-1',N'Không có'),
(N'Sữa tươi',null,25000,'2022-11-1',N'Không có'),
(N'Bánh cá',null,25000,'2022-11-1',N'Không có'),
(N'Trà sữa',null,25000,'2022-11-1',N'Không có'),
(N'Cam ép',null,25000,'2022-11-1',N'Không có')

insert into EMPLOYEE(employee_id,employee_name,employee_img,phone_number,birth,gender,position)
values
('abc',N'Phước', null, '0357648144','2002-7-5',0,N'Bán hàng'),
('aaa',N'Nhật', null, '0123456789','2002-1-1',0,N'Bán hàng'),
('bbb',N'Đồng', null, '0246813579','2002-1-1',0,N'Bán hàng'),
('admin',N'Quang',null,'0123456787','2002-1-1',0,N'Chủ tiệm')


insert into ACCOUNT(employee_id,passwd,permission)
values
('abc','123456789',0),
('aaa','123456789',0),
('bbb','123456789',0),
('admin','123456789',1)


insert into VOUCHER(voucher_id,apply_price,off_percent,max_money,used)
values
('Khong',0,0,null,0),
('10%off',0,10,null,0),
('20%off',0,20,null,0),
('30%off',0,30,null,0),
('40%off',0,40,null,0),
('giamgiane',0,20,null,0)




exec add_Bill 'bill1','9-17-2022','aaa','Khong'
exec add_Bill 'bill2','9-17-2022','aaa','giamgiane'

exec add_Bill 'bill3','2022-10-1','aaa','Khong'
exec add_Bill 'bill4','2022-10-1','aaa','giamgiane'

exec add_Bill 'bill5','2022-11-1','aaa','Khong'
exec add_Bill 'bill6','2022-10-1','aaa','giamgiane'

exec add_Bill 'bill7','2022-8-1','aaa','Khong'
exec add_Bill 'bill8','2022-8-1','aaa','giamgiane'

exec add_Bill 'bill9','2022-7-1','aaa','Khong'
exec add_Bill 'bill0','2022-7-1','aaa','giamgiane'


exec add_Bill_detail 'bill1',1,2
exec add_Bill_detail 'bill1',2,2

exec add_Bill_detail 'bill2',2,1
exec add_Bill_detail 'bill2',3,2

exec add_Bill_detail 'bill3',2,1
exec add_Bill_detail 'bill3',1,2

exec add_Bill_detail 'bill4',3,1
exec add_Bill_detail 'bill4',1,2

exec add_Bill_detail 'bill5',2,1
exec add_Bill_detail 'bill5',3,2

exec add_Bill_detail 'bill6',3,1
exec add_Bill_detail 'bill6',1,2

exec add_Bill_detail 'bill7',2,1
exec add_Bill_detail 'bill7',1,2

exec add_Bill_detail 'bill8',3,1

exec add_Bill_detail 'bill9',1,2

exec add_Bill_detail 'bill0',3,1
exec add_Bill_detail 'bill0',1,2




exec update_Bill 'bill1'
go
exec update_Bill 'bill2'
go
exec update_Bill 'bill3'
go
exec update_Bill 'bill4'
go
exec update_Bill 'bill5'
go
exec update_Bill 'bill6'
go
exec update_Bill 'bill7'
go
exec update_Bill 'bill8'
go
exec update_Bill 'bill9'
go
exec update_Bill 'bill0'


