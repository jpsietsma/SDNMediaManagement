

CREATE PROCEDURE [dbo].[GetMovies] 
	-- Add the parameters for the stored procedure here
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM dbo.Movies
END