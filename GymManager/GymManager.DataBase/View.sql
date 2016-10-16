USE GymManager;

GO
CREATE VIEW vAllInfo
AS
        SELECT
	            u.Id AS 'Id',
                u.Name + ' ' + u.Surname AS 'Name Surname',
                u.Email AS 'E-mail',
				CASE WHEN u.PhoneNumber IS NULL THEN '0' ELSE u.PhoneNumber END  AS 'Phone',
                u.CardNumber AS 'Card Number',
				c.TypeCard AS 'Card Type',
				c.RegistrationDate AS 'Registration Date',
				c.EndDate AS 'End Date',
				CASE WHEN (CONVERT(INT,c.Price)/DATEDIFF(m,c.RegistrationDate,c.EndDate))*DATEDIFF(m, CONVERT(DATE,GETDATE()), EndDate)<=0 THEN '0' ELSE (CONVERT(INT,c.Price)/DATEDIFF(m,c.RegistrationDate,c.EndDate))*DATEDIFF(m, CONVERT(DATE,GETDATE()), EndDate) END AS 'Balance',
                a.Name + ' ' + a.Surname AS 'Administrator',
				CASE WHEN c.IsActive=1 THEN 'Active' ELSE 'Disabled' END AS 'Card Status'
                FROM tblCustomer u
				LEFT JOIN tblCard c ON c.CardNumber = u.CardNumber
                LEFT JOIN tblAdministrator a ON a.Id = c.AdminId
            
GO