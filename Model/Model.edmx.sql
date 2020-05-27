
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/16/2020 01:59:02
-- Generated from EDMX file: C:\Users\mandr\source\repos\Proiect2020\ClassLibrary4\Model\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [student];
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

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PictureId] int  NOT NULL,
    [person_name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pictures'
CREATE TABLE [dbo].[Pictures] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Date] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Details'
CREATE TABLE [dbo].[Details] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PictureId] int  NOT NULL,
    [eveniment] nvarchar(max)  NOT NULL,
    [location] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pictures'
ALTER TABLE [dbo].[Pictures]
ADD CONSTRAINT [PK_Pictures]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Details'
ALTER TABLE [dbo].[Details]
ADD CONSTRAINT [PK_Details]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PictureId] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [FK_PicturePerson]
    FOREIGN KEY ([PictureId])
    REFERENCES [dbo].[Pictures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PicturePerson'
CREATE INDEX [IX_FK_PicturePerson]
ON [dbo].[People]
    ([PictureId]);
GO

-- Creating foreign key on [PictureId] in table 'Details'
ALTER TABLE [dbo].[Details]
ADD CONSTRAINT [FK_PictureDetails]
    FOREIGN KEY ([PictureId])
    REFERENCES [dbo].[Pictures]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PictureDetails'
CREATE INDEX [IX_FK_PictureDetails]
ON [dbo].[Details]
    ([PictureId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------