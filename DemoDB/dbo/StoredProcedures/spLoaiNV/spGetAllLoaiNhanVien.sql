﻿CREATE PROCEDURE [dbo].[spGetAllLoaiNhanVien]
AS
	BEGIN
		SET NOCOUNT ON;
		SELECT * FROM [dbo].[LoaiNV];
	END
RETURN 0