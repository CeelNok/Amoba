
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/15/2020 17:06:06
-- Generated from EDMX file: D:\Patrik\Github\Amoba\amobagame\Amoba\Amoba\Amoba\edmGames.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Games];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[GamesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[GamesSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'GamesSet'
CREATE TABLE [dbo].[GamesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [player1] nvarchar(max)  NOT NULL,
    [player2] nvarchar(max)  NOT NULL,
    [winner] nvarchar(max)  NOT NULL,
    [date] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'GamesSet'
ALTER TABLE [dbo].[GamesSet]
ADD CONSTRAINT [PK_GamesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------