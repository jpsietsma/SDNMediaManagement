-- =============================================
-- Author:		Jimmy Sietsma
-- Create date: 11/19/2018
-- Description:	Revoke an identity role from a user by passing the username and desired role
-- =============================================
CREATE PROCEDURE RevokeUserSDNRole 
	-- Add the parameters for the stored procedure here
	@userName NVARCHAR(100),
	@userRole NVARCHAR(20) 

AS
BEGIN
	
	SET NOCOUNT ON;

	DECLARE @count INT;

	--User ID of user which to revoke Role from
	DECLARE @userId NVARCHAR(75) = (SELECT Id FROM AspNetUsers WHERE UserName = @userName);

	--Role ID of the role from which to remove the user
	DECLARE @roleId NVARCHAR(75) = (SELECT Id FROM AspNetRoles WHERE Name = @userRole);


	--get number of records for this user/role combo in AspNetUserRoles, if # = 1 then remove, else do nothing
	SET @count = (SELECT Count(UserId) FROM dbo.AspNetUserRoles WHERE UserId = @userId AND RoleId = @roleId);

	if(@count = 1)
	BEGIN

	DELETE FROM AspNetUserRoles WHERE UserId = @userId AND RoleId = @roleId
    
	END

END