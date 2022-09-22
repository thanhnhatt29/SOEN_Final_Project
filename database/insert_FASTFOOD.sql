use FASTFOOD
go

exec add_Employee 'abc',N'Phước', 0357648144,false,'administrator'
exec add_Employee 'aaa',N'Nhật', 0123456789,false,'manager'


exec add_Account 'abc',0357648144,true
exec add_Account 'aaa',0123456789,false

exec add_Product N'Cà phê',20000,'2000-2-2', N'Không có'
exec add_Product N'Gà chiên',50000,'2000-2-2',N'Không có'
exec add_Product N'CocaCola',10000,'2000-2-2',N'Không có'
exec add_Product N'Cơm trưa',30000,'2022-9-17','Không có'

exec add_Voucher 'Khong',0,0
exec add_Voucher 'giamgiane',0,20

exec add_Bill 'bill1','9-17-2022','aaa','Khong'
exec add_Bill 'bill2','9-17-2022','aaa','giamgiane'

exec add_Bill_detail 'bill1',1,2
exec add_Bill_detail 'bill1',2,2
exec add_Bill_detail 'bill2',2,1


exec update_Bill 'bill1'

exec update_Bill 'bill2'

/*
select*from BILL
select off_percent from VOUCHER where voucher_id=(select voucher_id from BILL where bill_id='bill2')
select *from VOUCHER
select(50000-20000)
*/
