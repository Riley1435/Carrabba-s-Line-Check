CREATE SCHEMA [LineCheck]
   AUTHORIZATION [dbo];
GO
CREATE TABLE [LineCheck].[PizzaMisc]
(
   [_Date] DATETIME NOT NULL,
   [Equipment] NVARCHAR (40) NOT NULL,
   [Present] NVARCHAR (1) NOT NULL,
   [Username] NVARCHAR (40) NOT NULL
);
GO

CREATE TABLE [LineCheck].[PizzaFood]
(
   [_Date] DATETIME NOT NULL,
   [Food] NVARCHAR (40) NOT NULL,
   [Appearance] NVARCHAR (1) NOT NULL,
   [Taste] NVARCHAR (1) NOT NULL,
   [Temp] NVARCHAR (1) NOT NULL,
   [Username] NVARCHAR (40) NOT NULL
);
GO

CREATE TABLE [LineCheck].[AppMisc]
(
   [_Date] DATETIME NOT NULL,
   [Equipment] NVARCHAR (40) NOT NULL,
   [Present] NVARCHAR (1) NOT NULL,
   [Username] NVARCHAR (40) NOT NULL
);
GO

CREATE TABLE [LineCheck].[AppFood]
(
   [_Date] DATETIME NOT NULL,
   [Food] NVARCHAR (40) NOT NULL,
   [Appearance] NVARCHAR (1) NOT NULL,
   [Taste] NVARCHAR (1) NOT NULL,
   [Temp] NVARCHAR (1) NOT NULL,
   [Username] NVARCHAR (40) NOT NULL
);
GO

CREATE TABLE [LineCheck].[DessertFood]
(
   [_Date] DATETIME NOT NULL,
   [Food] NVARCHAR (40) NOT NULL,
   [Appearance] NVARCHAR (1) NOT NULL,
   [Taste] NVARCHAR (1) NOT NULL,
   [Temp] NVARCHAR (1) NOT NULL,
   [Username] NVARCHAR (40) NOT NULL
);
GO

CREATE TABLE [LineCheck].[SaladMisc]
(
   [_Date] DATETIME NOT NULL,
   [Equipment] NVARCHAR (40) NOT NULL,
   [Present] NVARCHAR (1) NOT NULL,
   [Username] NVARCHAR (40) NOT NULL
);
GO

CREATE TABLE [LineCheck].[SaladFood]
(
   [_Date] DATETIME NOT NULL,
   [Food] NVARCHAR (40) NOT NULL,
   [Appearance] NVARCHAR (1) NOT NULL,
   [Taste] NVARCHAR (1) NOT NULL,
   [Temp] NVARCHAR (1) NOT NULL,
   [Username] NVARCHAR (40) NOT NULL
);
GO

CREATE TABLE [LineCheck].[GrillMisc]
(
   [_Date] DATETIME NOT NULL,
   [Equipment] NVARCHAR (40) NOT NULL,
   [Present] NVARCHAR (1) NOT NULL,
   [Username] NVARCHAR (40) NOT NULL
);
GO

CREATE TABLE [LineCheck].[GrillFood]
(
   [_Date] DATETIME NOT NULL,
   [Food] NVARCHAR (40) NOT NULL,
   [Appearance] NVARCHAR (1) NOT NULL,
   [Taste] NVARCHAR (1) NOT NULL,
   [Temp] NVARCHAR (1) NOT NULL,
   [Username] NVARCHAR (40) NOT NULL
);
GO

CREATE TABLE [LineCheck].[MakeupMisc]
(
   [_Date] DATETIME NOT NULL,
   [Equipment] NVARCHAR (40) NOT NULL,
   [Present] NVARCHAR (1) NOT NULL,
   [Username] NVARCHAR (40) NOT NULL
);
GO

CREATE TABLE [LineCheck].[MakeupFood]
(
   [_Date] DATETIME NOT NULL,
   [Food] NVARCHAR (40) NOT NULL,
   [Appearance] NVARCHAR (1) NOT NULL,
   [Taste] NVARCHAR (1) NOT NULL,
   [Temp] NVARCHAR (1) NOT NULL,
   [Username] NVARCHAR (40) NOT NULL
);
GO

CREATE TABLE [LineCheck].[SauteeMisc]
(
   [_Date] DATETIME NOT NULL,
   [Equipment] NVARCHAR (40) NOT NULL,
   [Present] NVARCHAR (1) NOT NULL,
   [Username] NVARCHAR (40) NOT NULL
);
GO

CREATE TABLE [LineCheck].[SauteeFood]
(
   [_Date] DATETIME NOT NULL,
   [Food] NVARCHAR (40) NOT NULL,
   [Appearance] NVARCHAR (1) NOT NULL,
   [Taste] NVARCHAR (1) NOT NULL,
   [Temp] NVARCHAR (1) NOT NULL,
   [Username] NVARCHAR (40) NOT NULL
);
GO

CREATE PROCEDURE [LineCheck].[uspNewLineCheckPizzaMisc]
@_Date DATETIME, @Equipment NVARCHAR (40), @Present NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
INSERT INTO	[LineCheck].[PizzaMisc](_Date,Equipment,Present,Username) VALUES(@_Date,@Equipment,@Present,@Username);
END
GO

CREATE PROCEDURE [LineCheck].[uspNewLineCheckAppMisc]
@_Date DATETIME, @Equipment NVARCHAR (40), @Present NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
INSERT INTO	[LineCheck].[AppMisc](_Date,Equipment,Present,Username) VALUES(@_Date,@Equipment,@Present,@Username);
END
GO

CREATE PROCEDURE [LineCheck].[uspNewLineCheckSaladMisc]
@_Date DATETIME, @Equipment NVARCHAR (40), @Present NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
INSERT INTO	[LineCheck].[SaladMisc](_Date,Equipment,Present,Username) VALUES(@_Date,@Equipment,@Present,@Username);
END
GO

CREATE PROCEDURE [LineCheck].[uspNewLineCheckGrillMisc]
@_Date DATETIME, @Equipment NVARCHAR (40), @Present NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
INSERT INTO	[LineCheck].[GrillMisc](_Date,Equipment,Present,Username) VALUES(@_Date,@Equipment,@Present,@Username);
END
GO

CREATE PROCEDURE [LineCheck].[uspNewLineCheckMakeupMisc]
@_Date DATETIME, @Equipment NVARCHAR (40), @Present NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
INSERT INTO	[LineCheck].[MakeupMisc](_Date,Equipment,Present,Username) VALUES(@_Date,@Equipment,@Present,@Username);
END
GO

CREATE PROCEDURE [LineCheck].[uspNewLineCheckSauteeMisc]
@_Date DATETIME, @Equipment NVARCHAR (40), @Present NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
INSERT INTO	[LineCheck].[SauteeMisc](_Date,Equipment,Present,Username) VALUES(@_Date,@Equipment,@Present,@Username);
END
GO
-- BREAK --


CREATE PROCEDURE [LineCheck].[uspNewLineCheckPizzaFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
INSERT INTO	[LineCheck].[PizzaFood](_Date,Food,Appearance,Taste,Temp,Username) VALUES(@_Date,@Food,@Appearance,@Taste,@Temp,@Username);
END
GO

CREATE PROCEDURE [LineCheck].[uspNewLineCheckAppFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
INSERT INTO	[LineCheck].[AppFood](_Date,Food,Appearance,Taste,Temp,Username) VALUES(@_Date,@Food,@Appearance,@Taste,@Temp,@Username);
END
GO

CREATE PROCEDURE [LineCheck].[uspNewLineCheckDessertFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
INSERT INTO	[LineCheck].[DessertFood](_Date,Food,Appearance,Taste,Temp,Username) VALUES(@_Date,@Food,@Appearance,@Taste,@Temp,@Username);
END
GO

CREATE PROCEDURE [LineCheck].[uspNewLineCheckSaladFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
INSERT INTO	[LineCheck].[SaladFood](_Date,Food,Appearance,Taste,Temp,Username) VALUES(@_Date,@Food,@Appearance,@Taste,@Temp,@Username);
END
GO

CREATE PROCEDURE [LineCheck].[uspNewLineCheckGrillFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
INSERT INTO	[LineCheck].[GrillFood](_Date,Food,Appearance,Taste,Temp,Username) VALUES(@_Date,@Food,@Appearance,@Taste,@Temp,@Username);
END
GO

CREATE PROCEDURE [LineCheck].[uspNewLineCheckMakeupFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
INSERT INTO	[LineCheck].[MakeupFood](_Date,Food,Appearance,Taste,Temp,Username) VALUES(@_Date,@Food,@Appearance,@Taste,@Temp,@Username);
END
GO

CREATE PROCEDURE [LineCheck].[uspNewLineCheckSauteeFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
INSERT INTO	[LineCheck].[SauteeFood](_Date,Food,Appearance,Taste,Temp,Username) VALUES(@_Date,@Food,@Appearance,@Taste,@Temp,@Username);
END
GO

-- //     --
-- Update -- 
-- //     --

CREATE PROCEDURE [LineCheck].[uspUpdatePizzaFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [LineCheck].[PizzaFood]
SET [Appearance] = @Appearance,
    [Taste] = @Taste,
    [Temp] = @Temp,
    [Username] = @Username
WHERE [_Date] = @_Date AND [Food] = @Food;
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspUpdateAppFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [LineCheck].[AppFood]
SET [Appearance] = @Appearance,
    [Taste] = @Taste,
    [Temp] = @Temp,
    [Username] = @Username
WHERE [_Date] = @_Date AND [Food] = @Food;
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspUpdateSaladFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [LineCheck].[SaladFood]
SET [Appearance] = @Appearance,
    [Taste] = @Taste,
    [Temp] = @Temp,
    [Username] = @Username
WHERE [_Date] = @_Date AND [Food] = @Food;
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspUpdateDessertFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [LineCheck].[DessertFood]
SET [Appearance] = @Appearance,
    [Taste] = @Taste,
    [Temp] = @Temp,
    [Username] = @Username
WHERE [_Date] = @_Date AND [Food] = @Food;
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspUpdateGrillFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [LineCheck].[GrillFood]
SET [Appearance] = @Appearance,
    [Taste] = @Taste,
    [Temp] = @Temp,
    [Username] = @Username
WHERE [_Date] = @_Date AND [Food] = @Food;
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspUpdateMakeupFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [LineCheck].[MakeupFood]
SET [Appearance] = @Appearance,
    [Taste] = @Taste,
    [Temp] = @Temp,
    [Username] = @Username
WHERE [_Date] = @_Date AND [Food] = @Food;
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspUpdateSauteeFood]
@_Date DATETIME, @Food NVARCHAR (40), @Appearance NVARCHAR (1),
@Taste NVARCHAR (1), @Temp NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [LineCheck].[SauteeFood]
SET [Appearance] = @Appearance,
    [Taste] = @Taste,
    [Temp] = @Temp,
    [Username] = @Username
WHERE [_Date] = @_Date AND [Food] = @Food;
COMMIT TRANSACTION
END
GO

-- 
-- UPDATE MISC --
-- 
-- 
CREATE PROCEDURE [LineCheck].[uspUpdatePizzaMisc]
@_Date DATETIME, @Equipment NVARCHAR (40), @Present NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [LineCheck].[PizzaMisc]
SET [Present] = @Present,
    [Username] = @Username
WHERE [_Date] = @_Date AND [Equipment] = @Equipment;
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspUpdateAppMisc]
@_Date DATETIME, @Equipment NVARCHAR (40), @Present NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [LineCheck].[AppMisc]
SET [Present] = @Present,
    [Username] = @Username
WHERE [_Date] = @_Date AND [Equipment] = @Equipment;
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspUpdateSaladMisc]
@_Date DATETIME, @Equipment NVARCHAR (40), @Present NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [LineCheck].[SaladMisc]
SET [Present] = @Present,
    [Username] = @Username
WHERE [_Date] = @_Date AND [Equipment] = @Equipment;
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspUpdateGrillMisc]
@_Date DATETIME, @Equipment NVARCHAR (40), @Present NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [LineCheck].[GrillMisc]
SET [Present] = @Present,
    [Username] = @Username
WHERE [_Date] = @_Date AND [Equipment] = @Equipment;
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspUpdateMakeupMisc]
@_Date DATETIME, @Equipment NVARCHAR (40), @Present NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [LineCheck].[MakeupMisc]
SET [Present] = @Present,
    [Username] = @Username
WHERE [_Date] = @_Date AND [Equipment] = @Equipment;
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspUpdateSauteeMisc]
@_Date DATETIME, @Equipment NVARCHAR (40), @Present NVARCHAR (1), @Username NVARCHAR (40)
AS
BEGIN
BEGIN TRANSACTION
UPDATE [LineCheck].[SauteeMisc]
SET [Present] = @Present,
    [Username] = @Username
WHERE [_Date] = @_Date AND [Equipment] = @Equipment;
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspSelectEquipment]
@_Date DATETIME
AS
BEGIN
BEGIN TRANSACTION
SELECT * FROM [LineCheck].[PizzaMisc]
WHERE _Date = @_Date AND Present = 'O'
UNION
SELECT * FROM [LineCheck].[AppMisc]
WHERE _Date = @_Date AND Present = 'O'
UNION
SELECT * FROM [LineCheck].[SaladMisc]
WHERE _Date = @_Date AND Present = 'O'
UNION
SELECT * FROM [LineCheck].[GrillMisc]
WHERE _Date = @_Date AND Present = 'O'
UNION
SELECT * FROM [LineCheck].[MakeupMisc]
WHERE _Date = @_Date AND Present = 'O'
UNION
SELECT * FROM [LineCheck].[SauteeMisc]
WHERE _Date = @_Date AND Present = 'O'
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspSelectIngredients]
@_Date DATETIME
AS
BEGIN
BEGIN TRANSACTION
SELECT * FROM [LineCheck].[PizzaFood]
WHERE _Date = @_Date AND (Appearance = 'O' OR Taste = 'O' OR Temp = 'O')
UNION
SELECT * FROM [LineCheck].[AppFood]
WHERE _Date = @_Date AND (Appearance = 'O' OR Taste = 'O' OR Temp = 'O')
UNION
SELECT * FROM [LineCheck].[DessertFood]
WHERE _Date = @_Date AND (Appearance = 'O' OR Taste = 'O' OR Temp = 'O')
UNION
SELECT * FROM [LineCheck].[SaladFood]
WHERE _Date = @_Date AND (Appearance = 'O' OR Taste = 'O' OR Temp = 'O')
UNION
SELECT * FROM [LineCheck].[GrillFood]
WHERE _Date = @_Date AND (Appearance = 'O' OR Taste = 'O' OR Temp = 'O')
UNION
SELECT * FROM [LineCheck].[MakeupFood]
WHERE _Date = @_Date AND (Appearance = 'O' OR Taste = 'O' OR Temp = 'O')
UNION
SELECT * FROM [LineCheck].[SauteeFood]
WHERE _Date = @_Date AND (Appearance = 'O' OR Taste = 'O' OR Temp = 'O')
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspSelectAllFood]
@_DateMin DATETIME, @_DateMax DATETIME
AS
BEGIN
BEGIN TRANSACTION
SELECT * FROM [LineCheck].[PizzaFood]
WHERE _Date >= @_DateMin AND _Date <= @_DateMax
UNION
SELECT * FROM [LineCheck].[AppFood]
WHERE _Date >= @_DateMin AND _Date <= @_DateMax
UNION
SELECT * FROM [LineCheck].[DessertFood]
WHERE _Date >= @_DateMin AND _Date <= @_DateMax
UNION
SELECT * FROM [LineCheck].[SaladFood]
WHERE _Date >= @_DateMin AND _Date <= @_DateMax
UNION
SELECT * FROM [LineCheck].[GrillFood]
WHERE _Date >= @_DateMin AND _Date <= @_DateMax
UNION
SELECT * FROM [LineCheck].[MakeupFood]
WHERE _Date >= @_DateMin AND _Date <= @_DateMax
UNION
SELECT * FROM [LineCheck].[SauteeFood]
WHERE _Date >= @_DateMin AND _Date <= @_DateMax
COMMIT TRANSACTION
END
GO

CREATE PROCEDURE [LineCheck].[uspSelectAllMisc]
@_DateMin DATETIME, @_DateMax DATETIME
AS
BEGIN
BEGIN TRANSACTION
SELECT * FROM [LineCheck].[PizzaMisc]
WHERE _Date >= @_DateMin AND _Date <= @_DateMax
UNION
SELECT * FROM [LineCheck].[AppMisc]
WHERE _Date >= @_DateMin AND _Date <= @_DateMax
UNION
SELECT * FROM [LineCheck].[SaladMisc]
WHERE _Date >= @_DateMin AND _Date <= @_DateMax
UNION
SELECT * FROM [LineCheck].[GrillMisc]
WHERE _Date >= @_DateMin AND _Date <= @_DateMax
UNION
SELECT * FROM [LineCheck].[MakeupMisc]
WHERE _Date >= @_DateMin AND _Date <= @_DateMax
UNION
SELECT * FROM [LineCheck].[SauteeMisc]
WHERE _Date >= @_DateMin AND _Date <= @_DateMax
COMMIT TRANSACTION
END
GO









