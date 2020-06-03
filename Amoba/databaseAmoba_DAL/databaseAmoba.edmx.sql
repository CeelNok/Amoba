
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/04/2020 12:05:59
-- Generated from EDMX file: D:\Patrik\Github\Amoba\amobagame\Amoba\Amoba\databaseAmoba_DAL\databaseAmoba.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [databaseAmoba];
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
    [p1Name] nvarchar(max)  NOT NULL,
    [p2Name] nvarchar(max)  NOT NULL,
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