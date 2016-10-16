CREATE DATABASE GymManager;

GO
USE GymManager
GO

IF OBJECT_ID('tblAdministrator','U') IS NOT NULL
 		DROP TABLE tblAdministrator;

CREATE TABLE tblAdministrator
(
	Id INT NOT NULL IDENTITY(1, 1),
	Name VARCHAR(15) NOT NULL,
	Surname VARCHAR(15) NOT NULL,
	[Login] VARCHAR(20) NOT NULL,
	[Password] VARCHAR(100) NOT NULL,
	IsActive BIT NOT NULL,
	CONSTRAINT Pk_tblAdministrator_ID PRIMARY KEY(Id)
)

IF OBJECT_ID('tblCard','U') IS NOT NULL
 BEGIN
		ALTER TABLE tblCustomer
		DROP CONSTRAINT Fk_tblCustomer_CardNumber_tblCard_CartNumber
		ALTER TABLE tblService
		DROP CONSTRAINT Fk_tblService_CardNumber_tblCard_CartNumber
		ALTER TABLE tblVisiting
		DROP CONSTRAINT Fk_tblVisiting_CardNumber_tblCard_CartNumber
 		DROP TABLE tblCard;
 END

CREATE TABLE tblCard
(
	CardNumber INT NOT NULL IDENTITY(100,1),
	TypeCard VARCHAR(20) NOT NULL,
	RegistrationDate DATE NOT NULL,
	EndDate DATE NOT NULL,
	IsActive BIT NOT NULL,
	Price MONEY NOT NULL,
	AdminId INT NOT NULL,
	CONSTRAINT Pk_tblCard_CardNumber PRIMARY KEY(CardNumber),
	CONSTRAINT Fk_tblCard_AdminId_tblAdministrator_Id FOREIGN KEY(AdminId) REFERENCES tblAdministrator(Id)
)

GO
IF OBJECT_ID('tblCustomer','U') IS NOT NULL
	DROP TABLE tblCustomer

CREATE TABLE tblCustomer
(
	Id INT NOT NULL IDENTITY(1, 1),
	Name VARCHAR(15) NOT NULL,
	Surname VARCHAR(15) NOT NULL,
	Street NVARCHAR(50) NULL,
	HouseNumber INT NULL,
	PhoneNumber VARCHAR(12) NULL,
	Email VARCHAR(30) NOT NULL,
	CardNumber INT NOT NULL,
	CONSTRAINT Pk_tblCustomer_ID PRIMARY KEY(Id),
	CONSTRAINT Fk_tblCustomer_CardNumber_tblCard_CartNumber FOREIGN KEY(CardNumber) REFERENCES tblCard(CardNumber)
)

IF OBJECT_ID('tblVisiting','U') IS NOT NULL
 		DROP TABLE tblVisiting;

CREATE TABLE tblVisiting
(
	CardNumber INT NOT NULL,
	KeyNumber INT NOT NULL,
	DateVisit DATE NOT NULL, 
	CONSTRAINT Fk_tblVisiting_CardNumber_tblCard_CartNumber FOREIGN KEY(CardNumber) REFERENCES tblCard(CardNumber)
)
GO