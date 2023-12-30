IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'PracticeChallenge')
BEGIN
    CREATE DATABASE PracticeChallenge
END
GO

USE PracticeChallenge
GO

CREATE TABLE PermissionTypes
(
    Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    Description VARCHAR(50) NOT NULL
)
GO

CREATE TABLE [Permissions]
(
    Id INT PRIMARY KEY NOT NULL IDENTITY(1,1),
    EmployeeName NVARCHAR(100) NOT NULL,
    EmployeeLastName NVARCHAR(100) NOT NULL,
    PermissionDate DATETIME NOT NULL,
    PermissionTypeId INT FOREIGN KEY REFERENCES PermissionTypes(Id) NOT NULL
)
GO