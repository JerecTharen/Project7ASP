USE [TestDB]
GO

/****** Object: Table [dbo].[Users] Script Date: 4/20/2019 11:32:50 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/*CREATE TABLE [dbo].[Users] (
    [Id]         INT  NOT NULL,
    [user_name]  TEXT NULL,
    [first_name] TEXT NULL,
    [last_name]  TEXT NULL,
    [age]        INT  NULL,
    [email]      TEXT NULL
);*/

INSERT INTO
Users
(Id, user_name, first_name, last_name, age, email)
VALUES
(3,'MaldenThule', 'Malden', 'Thul', 30, 'malden@tharen.com');

SELECT * FROM Users;


