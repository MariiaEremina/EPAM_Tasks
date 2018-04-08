/*
Скрипт развертывания для Users_n_Rewards

Этот код был создан программным средством.
Изменения, внесенные в этот файл, могут привести к неверному выполнению кода и будут потеряны
в случае его повторного формирования.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Users_n_Rewards"
:setvar DefaultFilePrefix "Users_n_Rewards"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\"

GO
:on error exit
GO
/*
Проверьте режим SQLCMD и отключите выполнение скрипта, если режим SQLCMD не поддерживается.
Чтобы повторно включить скрипт после включения режима SQLCMD выполните следующую инструкцию:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'Для успешного выполнения этого скрипта должен быть включен режим SQLCMD.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Операция рефакторинга Rename с помощью ключа  пропущена, элемент [dbo].[Users].[Id] (SqlSimpleColumn) не будет переименован в ID';


GO
PRINT N'Операция рефакторинга Rename с помощью ключа  пропущена, элемент [dbo].[Rewards].[Id] (SqlSimpleColumn) не будет переименован в ID';


GO
PRINT N'Операция рефакторинга Rename с помощью ключа  пропущена, элемент [dbo].[Connection].[Id] (SqlSimpleColumn) не будет переименован в UserID';


GO

IF (SELECT OBJECT_ID('tempdb..#tmpErrors')) IS NOT NULL DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL READ COMMITTED
GO
BEGIN TRANSACTION
GO
PRINT N'Выполняется создание [dbo].[Connection]...';


GO
CREATE TABLE [dbo].[Connection] (
    [UserID]   INT NOT NULL,
    [RewardID] INT NOT NULL
);


GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO
PRINT N'Выполняется создание [dbo].[Rewards]...';


GO
CREATE TABLE [dbo].[Rewards] (
    [ID]          INT            NOT NULL,
    [Title]       NVARCHAR (50)  NOT NULL,
    [Discription] NVARCHAR (MAX) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO
PRINT N'Выполняется создание [dbo].[Users]...';


GO
CREATE TABLE [dbo].[Users] (
    [ID]         INT           NOT NULL,
    [FirstName]  NVARCHAR (50) NOT NULL,
    [SecondName] NVARCHAR (50) NOT NULL,
    [Birthdate]  DATE          NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO
PRINT N'Выполняется создание [dbo].[FK_Connection_ToUsers]...';


GO
ALTER TABLE [dbo].[Connection] WITH NOCHECK
    ADD CONSTRAINT [FK_Connection_ToUsers] FOREIGN KEY ([UserID]) REFERENCES [dbo].[Users] ([ID]);


GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO
PRINT N'Выполняется создание [dbo].[FK_Connection_ToRewards]...';


GO
ALTER TABLE [dbo].[Connection] WITH NOCHECK
    ADD CONSTRAINT [FK_Connection_ToRewards] FOREIGN KEY ([RewardID]) REFERENCES [dbo].[Rewards] ([ID]);


GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO
PRINT N'Выполняется создание [dbo].[GetUser]...';


GO
CREATE PROCEDURE [dbo].[GetUser]
	@id int
AS
	SELECT * FROM Users
WHERE ID= @id;
GO
IF @@ERROR <> 0
   AND @@TRANCOUNT > 0
    BEGIN
        ROLLBACK;
    END

IF @@TRANCOUNT = 0
    BEGIN
        INSERT  INTO #tmpErrors (Error)
        VALUES                 (1);
        BEGIN TRANSACTION;
    END


GO

IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT>0 BEGIN
PRINT N'Транзакции обновления базы данных успешно завершены.'
COMMIT TRANSACTION
END
ELSE PRINT N'Сбой транзакций обновления базы данных.'
GO
DROP TABLE #tmpErrors
GO
PRINT N'Существующие данные проверяются относительно вновь созданных ограничений';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Connection] WITH CHECK CHECK CONSTRAINT [FK_Connection_ToUsers];

ALTER TABLE [dbo].[Connection] WITH CHECK CHECK CONSTRAINT [FK_Connection_ToRewards];


GO
PRINT N'Обновление завершено.';


GO
