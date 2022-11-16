USE FASTFOOD
GO

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

/*
--COI CHỪNG LỖI FONT--

select*from BILL
select off_percent from VOUCHER where voucher_id=(select voucher_id from BILL where bill_id='bill2')
select *from VOUCHER
select(50000-20000)

*/
