CREATE procedure [dbo].[_create_new_branch]
	@vbranchcode	nvarchar(50),
	@vbranchname	nvarchar(50)
as 
begin
	

	update a set a.branchcode=@vbranchcode from sys_user_logins as a where a.user_id='1010-0001'
	delete a from sys_user_logins as a where a.branchcode <>@vbranchcode


	update a set a.branchcode=@vbranchcode from [tblcurrencies] as a  
	update a set a.branchcode=@vbranchcode from [tblCustomers] as a  
	update a set a.branchcode=@vbranchcode from [tblLines] as a  
	update a set a.branchcode=@vbranchcode from [tblRecordID] as a  
	update a set a.branchcode=@vbranchcode from [tblStockMenu] as a  
	update a set a.branchcode=@vbranchcode from tblSupplies as a  
	update a set a.branchcode=@vbranchcode from tblReports as a  

	update a set a.branchcode=@vbranchcode,recordid=1 from [tblRecordID] as a  WHERE A.convalue IN ('CUSTOMER','SUPPLY')


	DELETE A FROM [tblCustomers] AS A  WHERE A.cus_id<>'C0001'
	DELETE A FROM [tblSupplies] AS A  WHERE A.sup_id<>'S0001'

	DELETE A FROM [tblRecordID] AS A  WHERE A.convalue NOT IN ('TYPE_LINE','USER_ID','SUPPLY','CUSTOMER')


	---Delete record 

	delete from [His_tblunaInvoices]
	delete from [His_tblunaPurchaseOrder]

	delete from [His_tblunaPurchaseOrderDetail]
	delete from [His_tblunaStockOuts]

	delete from [tblcost]
	delete from [tblInvoices]
	delete from [tblexchangerates]
	delete from [tblProducts]
	delete from [tblPurchaseOrder]
	delete from [tblPurchaseOrderDetails]
	delete from [tblPurchaseOrderHistory]
	delete from [tblStockOuts]
	delete from [tblstocktransfers]
	delete from [tblstocktransferdetails]
	delete from [tblstocktransferdetails]
	delete from [TblTransactions]
	delete from [TblTransactions]
	delete from [tblunaInvoices]
	delete from [tblunaPurchaseOrder]
	delete from [tblunaPurchaseOrderDetails]
	delete from [tblunaStockOuts]
	delete from [tblunastocktransfers]
	delete from [tblunastocktransferdetails]
 

	DELETE A from [sysbranch] as a where a.branchcode=@vbranchcode
	INSERT INTO [dbo].[sysbranch]
           ([branchcode]
           ,[subofbranch]
           ,[is_branch]
           ,[Disable]
           ,[branchname]
           ,[branchshort]
           ,[inputter]
           ,[create_at]) values (@vbranchcode,'9090','1','0',@vbranchname,left(NEWID(),2),'IT.SYSTEM',GETDATE());
 


		 ---  EXEC _create_new_branch '0201','CLINIC'
		 ---  EXEC _create_new_branch '0401','CLINIC-04'


end