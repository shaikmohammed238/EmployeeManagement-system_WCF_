CREATE DATABASE EmployeeManagemnt_WCF

CREATE TABLE EmployeeManagemnt(
         Id int identity primary key,
		 [Name] VARCHAR(100) NOT NULL,
		 Salary BigInt NOT NULL,
		 Email VARCHAR(100) NOT NULL);
SELECT * FROM EmployeeManagemnt;
 INSERT INTO EmployeeManagemnt
 VALUES('Ghouse',10000,'shaik@gmail.com');