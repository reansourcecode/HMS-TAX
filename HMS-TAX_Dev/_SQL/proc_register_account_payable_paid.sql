ALTER PROCEDURE [dbo].[proc_register_account_payable_paid]
	@vCMD			nvarchar(20),
	@vsysdoc		nvarchar(20),
	@vbranchcode	nvarchar(20),
	@vap_id			nvarchar(20),
	@vpaid_date		date,
	@vamount		MONEY,
	@vremark		nvarchar(250),
	@vinputter		nvarchar(250)
AS
BEGIN

	SET NOCOUNT ON;
	-------------------------------------------------
	-- INSERT NEW commit
	-------------------------------------------------
	  IF (
		@vCMD = 'commit'
		AND EXISTS (
			SELECT 1
			FROM [tbl_account_payable]
			WHERE branchcode = @vBranchCode
			AND [ap_id] = @vap_id
		)
	)
	BEGIN

		EXEC proc_next_id
			@vBranchCode,
			'AccountPayablePaid',
			'9',
			@vsysdoc OUTPUT


		INSERT INTO [dbo].[tbl_account_payable_paid]
           ([sysdoc]
           ,[branchcode]
           ,[ap_id]
           ,[paiddate]
           ,[remark]
           ,[amount]
           ,[inputter]
           ,[created_at])
		   VALUES (@vsysdoc,@vbranchcode,@vap_id,@vpaid_date,@vremark,@vamount,@vinputter,GETDATE())

		   SET @vap_id =@vsysdoc 
	END
 
	SELECT @vap_id AS trancode

END
GO


