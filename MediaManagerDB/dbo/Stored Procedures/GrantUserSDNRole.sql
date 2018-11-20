-- =============================================
-- Author:		Jimmy Sietsma
-- Create date: 11/19/2018
-- Description:	Grant an identity role to a user by passing the username and desired role
-- =============================================
CREATE PROCEDURE GrantUserSDNRole 
	-- Add the parameters for the stored procedure here
	@userName NVARCHAR(100),
	@userRole NVARCHAR(20) 

AS
BEGIN
	
	SET NOCOUNT ON;


    INSERT INTO AspNetUserRoles ([UserId], [RoleId]) VALUES ((SELECT Id FROM AspNetUsers WHERE UserName = @userName), (SELECT Id FROM AspNetRoles WHERE Name = @userRole))

END
