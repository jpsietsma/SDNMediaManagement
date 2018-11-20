
CREATE PROCEDURE [dbo].[GetDisplayDuration] 
	@mins INT
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE
		@minutes INT,
		@hours INT,
		@days INT,
		@output NVARCHAR(50)

	SET @minutes = @mins
	SET @days = @minutes / 1440
	SET @minutes = @minutes - (@days * 1440)

	IF @minutes > 60
	BEGIN
		SET @hours = @minutes / 60
		SET @minutes = @minutes - (@hours * 60)
	END

	SET @output = CONCAT(@days, ' days, ', @hours, ' hours, ', @minutes, ' minutes') 
	
	SELECT @output AS "duration"

END
