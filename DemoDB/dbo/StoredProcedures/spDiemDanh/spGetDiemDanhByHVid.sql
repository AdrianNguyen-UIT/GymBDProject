CREATE PROCEDURE [dbo].[spGetDiemDanhByHVid]
	@MaHV INT
AS
	BEGIN
		SELECT *
		FROM [dbo].[DiemDanh]
		WHERE [MaHV] = @MaHV
	END
RETURN 0
