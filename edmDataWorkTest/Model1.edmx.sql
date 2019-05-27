
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/02/2019 17:17:12
-- Generated from EDMX file: C:\Users\nejip\source\repos\edmDataWorkTest\edmDataWorkTest\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DataWork];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_DivisionWorker]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkerSet] DROP CONSTRAINT [FK_DivisionWorker];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[DivisionSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DivisionSet];
GO
IF OBJECT_ID(N'[dbo].[WorkerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkerSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'DivisionSet'
CREATE TABLE [dbo].[DivisionSet] (
    [DivisionId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'WorkerSet'
CREATE TABLE [dbo].[WorkerSet] (
    [WorkerId] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Age] smallint  NOT NULL,
    [Division_DivisionId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [DivisionId] in table 'DivisionSet'
ALTER TABLE [dbo].[DivisionSet]
ADD CONSTRAINT [PK_DivisionSet]
    PRIMARY KEY CLUSTERED ([DivisionId] ASC);
GO

-- Creating primary key on [WorkerId] in table 'WorkerSet'
ALTER TABLE [dbo].[WorkerSet]
ADD CONSTRAINT [PK_WorkerSet]
    PRIMARY KEY CLUSTERED ([WorkerId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Division_DivisionId] in table 'WorkerSet'
ALTER TABLE [dbo].[WorkerSet]
ADD CONSTRAINT [FK_DivisionWorker]
    FOREIGN KEY ([Division_DivisionId])
    REFERENCES [dbo].[DivisionSet]
        ([DivisionId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DivisionWorker'
CREATE INDEX [IX_FK_DivisionWorker]
ON [dbo].[WorkerSet]
    ([Division_DivisionId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------