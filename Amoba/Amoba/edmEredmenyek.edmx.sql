
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/14/2020 10:30:29
-- Generated from EDMX file: D:\Patrik\Github\Amoba\amobagame\Amoba\Amoba\Amoba\edmEredmenyek.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [edmEredmenyek];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'eredmenyek'
CREATE TABLE [dbo].[eredmenyek] (
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

-- Creating primary key on [Id] in table 'eredmenyek'
ALTER TABLE [dbo].[eredmenyek]
ADD CONSTRAINT [PK_eredmenyek]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------