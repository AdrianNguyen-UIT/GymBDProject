﻿CREATE PROCEDURE [dbo].[spDeleteTuDo]
    @MaTD INT
AS
	BEGIN
		SET NOCOUNT ON;
		DELETE FROM [dbo].[TuDo]
		WHERE [MaTD] = @MaTD
 	END
RETURN 0