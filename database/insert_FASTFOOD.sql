use FASTFOOD
go

exec add_Employee 'abc',N'Ph???c', null, 0357648144,'2002-7-5',false,'administrator'
exec add_Employee 'aaa',N'Nh�?t', null, 0123456789,'2022-1-1',false,'manager'


exec add_Account 'abc','0357648144',true
exec add_Account 'aaa','0123456789',false

exec add_Product N'Ca? ph�',null,20000,'2000-2-2', N'Kh�ng co?'
exec add_Product N'Ga? chi�n',null,50000,'2000-2-2',N'Kh�ng co?'
exec add_Product N'CocaCola',null,10000,'2000-2-2',N'Kh�ng co?'
exec add_Product N'C?m tr?a',null,30000,'2022-9-17','Kh�ng co?'

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
