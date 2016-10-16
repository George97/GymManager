USE GymManager

GO
SET IDENTITY_INSERT tblAdministrator ON
INSERT INTO tblAdministrator (Id, Name, Surname,[Login], [Password], IsActive)
	VALUES
	(1, 'Admin', 'Gym', 'admin', 'b59c67bf196a4758191e42f76670ceba', 1),
	(2, 'Ad', 'G', 'adm', 'b59c67bf196a4758191e42f76670ceba', 1),
	(3, 'Gym', 'Adm', 'gym', 'b59c67bf196a4758191e42f76670ceba', 1),
	(4, 'Adminio', 'gymio', 'adgym', 'b59c67bf196a4758191e42f76670ceba', 0);
SET IDENTITY_INSERT tblAdministrator OFF

GO
SET IDENTITY_INSERT tblCard ON
INSERT INTO tblCard (CardNumber, TypeCard, RegistrationDate, EndDate, IsActive, Price, AdminID)
	VALUES
	(100, 'Full Day', '2016-01-15', '2017-01-15', 1, '3500', 1),
	(101, 'Morning', '2016-02-20', '2016-08-20', 0, '1900', 2),
	(102, 'Full Day', '2016-02-20', '2017-05-15', 1, '1900', 1),
	(103, 'Morning', '2016-02-20', '2017-01-15', 1, '1900', 3),
	(104, 'Full Day', '2016-02-20', '2017-06-15', 1, '5000', 1),
	(105, 'Morning', '2016-02-20', '2016-08-20', 0, '1900', 4),
	(106, 'Full Day', '2016-02-02', '2017-01-15', 1, '4000', 1),
	(107, 'Morning', '2016-02-20', '2016-08-20', 0, '1900', 2),
	(108, 'Evening', '2016-02-20', '2017-03-15', 1, '3500', 1),
	(109, 'Morning', '2016-01-15', '2016-08-20', 1, '1900', 3);
SET IDENTITY_INSERT tblCard OFF

INSERT INTO tblVisiting(CardNumber, KeyNumber, DateVisit)
    VALUES
    (100, 5, '2016-02-17'),
	(101, 7, '2016-03-27'),
    (102, 2, '2016-03-02'),
    (104, 5, '2016-03-25'),
    (100, 5, '2016-03-03'),
	(104, 5, '2016-05-17'),
	(101, 7, '2016-06-27'),
    (102, 2, '2016-03-02'),
    (104, 5, '2016-01-25'),
    (109, 3, '2016-02-03');
GO

SET IDENTITY_INSERT tblCustomer ON
INSERT INTO tblCustomer(Id, Name, Surname, Street, HouseNumber, PhoneNumber, Email, CardNumber)
    VALUES 
    (1,'Vasia', 'Nadich', 'Volodimira Velikoho', 14, '380987365987', 'nadich@gmail.com', 100),
    (2,'Mykhailo', 'Lex', 'Stryska', 123, '380657855566', 'lex@gmail.com', 101),
	(3, 'Virginia', 'Wagner', 'Lindbergh', 65, '38014300072', 'vwagner2@hatena.ne.jp', 102),
	(4, 'George', 'Ford', 'Barby', 7638, '409795276', 'gford3@clickbank.net', 103),
	(5, 'Benjamin', 'Webb', 'Arkansas', 58, '406054595', 'bwebb4@clickbank.net', 104),
	(6, 'Melissa', 'Brown', 'Ludington', 4513, '769716211', 'mbrown5@fema.gov', 105),
	(7, 'Patrick', 'Harper', 'Oak', 75641, '312056209', 'pharper6@admin.ch', 106),
	(8, 'Mark', 'Smith', 'Victoria', 3422, '499414778', 'msmith7@smugmug.com', 107),
	(9, 'Ralph', 'Nichols', 'Parkside', 9, '049962359', 'rnichols8@discuz.net', 108),
	(10, 'Craig', 'Stewart', 'Carberry', 2, '067625061', 'cstewart9@parallels.com', 109);
	SET IDENTITY_INSERT tblCustomer OFF