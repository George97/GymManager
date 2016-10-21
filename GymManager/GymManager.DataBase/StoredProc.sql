USE GymManager;

GO

-- Reviewer YM: In my opinion using transaction here made code complicated without any improvements  
CREATE PROCEDURE spGetExpirationDate
@CardNumber INT
AS
BEGIN TRAN
	BEGIN TRY
			DECLARE @Result INT;
			DECLARE @DateEnd DATE; 

			SELECT @DateEnd = EndDate FROM tblCard WHERE CardNumber = @CardNumber;
			SET @Result = DATEDIFF(d, CONVERT(DATE,GETDATE()), @DateEnd);
	COMMIT TRAN
END TRY

BEGIN CATCH
	ROLLBACK TRAN
END CATCH
	
	RETURN @Result;

GO
CREATE PROCEDURE spSelectAdmin
@Login VARCHAR(20),
@Password VARCHAR(100)
AS
	BEGIN
	SELECT 
		Id, 
		Name, 
		Surname, 
		[Login]
	FROM tblAdministrator
	WHERE [Login] = @Login AND [Password] = @Password AND IsActive <> 0;
END;
		
GO
CREATE PROCEDURE spAddNewCustomer
@Name VARCHAR(15),
@Surname VARCHAR(15),
@Street VARCHAR(50),
@HouseNumber INT,
@PhoneNumber NUMERIC(12,0),
@Email VARCHAR(30),
@Type VARCHAR(30),
@AdminId INT,
@ValidityInMonth INT,
@Price MONEY
AS
BEGIN TRAN
	BEGIN TRY
		DECLARE	@RegistrationDate DATE;
		DECLARE @EndDate DATE;
		DECLARE @IsActive BIT;
		DECLARE @CardNumber INT;

		SET @RegistrationDate = CONVERT(DATE, GETDATE());
		SET @EndDate = DATEADD(m, @ValidityInMonth, @RegistrationDate);
		SET @IsActive = 1;
		SELECT TOP 1 @CardNumber = CardNumber FROM tblCard 
		ORDER BY CardNumber DESC;
		SET @CardNumber += 1;

		INSERT INTO tblCard(TypeCard,RegistrationDate,EndDate,IsActive,Price, AdminId)
			VALUES
				(
				    @Type,
					@RegistrationDate,
					@EndDate,
					@IsActive,
					@Price,
					@AdminId
				);
		
		INSERT INTO tblCustomer(Name, Surname, Street, HouseNumber, PhoneNumber, Email, CardNumber)
			VALUES
				(
					@Name,
					@Surname,
					@Street,
					@HouseNumber,
					@PhoneNumber,
					@Email,
					@CardNumber
				);
	COMMIT TRAN
END TRY

BEGIN CATCH
	ROLLBACK TRAN
	SET @CardNumber = -1;
END CATCH

	RETURN @CardNUmber;

GO
CREATE PROCEDURE spAddNewAdministrator
@Name VARCHAR(15),
@Surname VARCHAR(15),
@Login VARCHAR(20),
@Password VARCHAR(100)
AS
BEGIN TRAN
	BEGIN TRY
		DECLARE @Id INT;
		
		INSERT INTO tblAdministrator(Name, Surname, [Login], [Password], IsActive)
			VALUES
				(
					@Name,
					@Surname, 
					@Login, 
					@Password,
					1
				);
		SELECT TOP 1 @Id = Id FROM tblAdministrator 
			ORDER BY Id DESC;
	COMMIT TRAN
END TRY

BEGIN CATCH
	SET @Id = -1	
	ROLLBACK TRAN
END CATCH

	RETURN @Id;
	
GO
CREATE PROCEDURE spSetActivityAdministrator
@Id INT,
@Status BIT
AS
BEGIN TRAN
	BEGIN TRY
		DECLARE @Result INT;
		
		UPDATE tblAdministrator
		SET IsActive = @Status
		WHERE Id = @Id

		SET @Result = 1;
	COMMIT TRAN
END TRY

BEGIN CATCH
	SET @Result = -1;
	ROLLBACK TRAN
END CATCH

	RETURN @Result

GO
CREATE PROCEDURE spSetCardActive
@CardNumber INT,
@Status BIT
AS
BEGIN TRAN
	BEGIN TRY
			DECLARE @Result INT;

			UPDATE tblCard
			SET IsActive = @Status
			WHERE CardNumber = @CardNumber;
			SET @Result = 1;
	COMMIT TRAN
END TRY

BEGIN CATCH
	SET @Result = -1;
	ROLLBACK TRAN
END CATCH	

	RETURN @Result

GO
CREATE PROCEDURE spChangeCardType
@CardNumber INT,
@Type VARCHAR(15)
AS
BEGIN TRAN
	BEGIN TRY
			DECLARE @Result INT;

			UPDATE tblCard
			SET TypeCard = @Type
			WHERE CardNumber = @CardNumber;
			SET @Result = 1;
	COMMIT TRAN
END TRY

BEGIN CATCH
	SET @Result = -1;
	ROLLBACK TRAN
END CATCH

	RETURN @Result

GO
CREATE PROCEDURE spChangePhoneNumber
@PhoneNumber NUMERIC(12,0),
@CardNumber INT
AS
BEGIN TRAN
	BEGIN TRY
			DECLARE @Result INT;

			UPDATE tblCustomer
			SET PhoneNumber = @PhoneNumber 
			WHERE CardNumber = @CardNumber;
			SET @Result = 1;
	COMMIT TRAN
END TRY

BEGIN CATCH
	SET @Result = -1;
	ROLLBACK TRAN
END CATCH

	RETURN @Result

GO
CREATE PROCEDURE spChangeEmail
@Email VARCHAR(30),
@CardNumber INT
AS
BEGIN TRAN
	BEGIN TRY
			DECLARE @Result INT;

			UPDATE tblCustomer
			SET Email= @Email
			WHERE CardNumber = @CardNumber;
			SET @Result = 1;
	COMMIT TRAN
END TRY

BEGIN CATCH
	SET @Result = -1;
	ROLLBACK TRAN
END CATCH

	RETURN @Result

GO
CREATE PROCEDURE spChangeAddress
@Street VARCHAR(50),
@HouseNumber INT,
@CardNumber INT
AS
BEGIN TRAN
	BEGIN TRY
			DECLARE @Result INT;
			
			UPDATE tblCustomer
			SET Street= @Street, HouseNumber = @HouseNumber
			WHERE CardNumber = @CardNumber;
			SET @Result = 1;
	COMMIT TRAN
END TRY

BEGIN CATCH
	SET @Result = -1;
	ROLLBACK TRAN
END CATCH

	RETURN @Result
	
GO
-- Reviewer YM: In my opinion using transaction here made code complicated without any improvements  
CREATE PROCEDURE spGetVisitsByKeyNumber
@KeyNumber INT
AS
BEGIN TRAN
	BEGIN TRY
		SELECT CardNumber, KeyNumber, DateVisit
		FROM tblVisiting
		WHERE KeyNumber = @KeyNumber
	COMMIT TRAN
END TRY

BEGIN CATCH
	ROLLBACK TRAN
END CATCH

GO
-- Reviewer YM: In my opinion using transaction here made code complicated without any improvements  
CREATE PROCEDURE spGetVisitsByDateVisit
@DateVisit VARCHAR(10)
AS
BEGIN TRAN
	BEGIN TRY
		SELECT CardNumber, KeyNumber, DateVisit
		FROM tblVisiting
		WHERE DateVisit = @DateVisit
	COMMIT TRAN
END TRY

BEGIN CATCH
	ROLLBACK TRAN
END CATCH

GO
CREATE PROCEDURE spExtendCard
@Month INT,
@Price MONEY,
@CardNumber INT
AS
BEGIN TRAN
	BEGIN TRY
		DECLARE @Result INT;

		UPDATE tblCard
		SET EndDate = DATEADD(m,@Month,CONVERT(DATE,GETDATE())), Price = @Price, IsActive = 1
		WHERE CardNumber = @CardNumber;
		SET @Result = 1;
	COMMIT TRAN
END TRY

BEGIN CATCH
	SET @Result = -1;
	ROLLBACK TRAN
END CATCH

	RETURN @Result

GO
-- Reviewer YM: In my opinion using transaction here made code complicated without any improvements  
CREATE PROCEDURE spGetBalance
@CardNumber INT
AS
BEGIN TRAN
	BEGIN TRY
		DECLARE @Balance INT

		SELECT @Balance = (CONVERT(INT,c.Price)/DATEDIFF(m,c.RegistrationDate,c.EndDate))*DATEDIFF(m, CONVERT(DATE,GETDATE()), EndDate) 
		FROM tblCard c
		WHERE c.CardNumber = @CardNumber
	COMMIT TRAN
END TRY

BEGIN CATCH
	ROLLBACK TRAN
END CATCH

	RETURN @Balance

GO
CREATE PROCEDURE spAddNewVisit
@CardNumber INT,
@KeyNumber INT
AS
BEGIN TRAN
	BEGIN TRY
		DECLARE @Result INT;

		INSERT INTO tblVisiting(CardNumber, KeyNumber, DateVisit)
		VALUES
		(
			@CardNumber,
			@KeyNumber,
			CONVERT(DATE,GETDATE())
		);
		SET @Result = 1;
	COMMIT TRAN
END TRY

BEGIN CATCH
	SET @Result = -1;
	ROLLBACK TRAN
END CATCH

	RETURN @Result
GO
