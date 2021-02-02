SELECT * FROM Departments --02. Find All Information About Departments

SELECT [Name] FROM Departments --03. Find all Department Names

SELECT [FirstName], [LastName], [Salary] FROM Employees --04. Find Salary of Each Employee

SELECT [FirstName], [MiddleName], [LastName] FROM Employees --05. Find Full Name of Each Employee

SELECT (FirstName + '.' + LastName + '@softuni.bg') AS 'Full Email Address' FROM Employees --06. Find Email Address of Each Employee

SELECT DISTINCT Salary  FROM Employees --07. Find All Different Employee’s Salaries

SELECT * FROM Employees WHERE JobTitle = 'Sales Representative' --08. Find all Information About Employees

SELECT FirstName, LastName, JobTitle FROM Employees WHERE (Salary >= 20000 AND Salary <= 30000) --09. Find Names of All Employees by Salary in Range

SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS [Full Name] FROM Employees WHERE (Salary = 25000 OR Salary = 14000 OR Salary = 12500 OR Salary = 23600) --10. Find Names of All Employees

SELECT FirstName, LastName FROM Employees WHERE ManagerID IS NULL --11. Find All Employees Without Manager

SELECT FirstName, LastName, Salary FROM Employees WHERE Salary > 50000 ORDER BY Salary DESC --12. Find All Employees with Salary More Than

SELECT TOP(5) FirstName, LastName FROM Employees ORDER BY Salary DESC --13. Find 5 Best Paid Employees

SELECT FirstName, LastName FROM Employees WHERE DepartmentID != 4 --14. Find All Employees Except Marketing

SELECT * FROM Employees ORDER BY Salary DESC, FirstName ASC, LastName DESC, MiddleName ASC --15. Sort Employees Table

CREATE VIEW V_EmployeesSalaries AS SELECT FirstName, LastName, Salary FROM Employees --16. Create View Employees with Salaries

CREATE VIEW V_EmployeeNameJobTitle AS SELECT CONCAT(FirstName, ' ', ISNULL(MiddleName, ''), ' ',LastName) AS [Full Name], JobTitle FROM Employees --17. Create View Employees with Job Titles

SELECT DISTINCT JobTitle FROM Employees --18. Distinct Job Titles

SELECT TOP(10) * FROM Projects ORDER BY StartDate ASC, [Name] ASC --19. Find First 10 Started Projects

SELECT TOP(7) FirstName, LastName, HireDate FROM Employees ORDER BY HireDate DESC --20. Last 7 Hired Employees

UPDATE Employees SET Salary += Salary * 0.12 WHERE DepartmentID IN (1, 2, 4, 11) --21. Increase Salaries

SELECT Salary FROM Employees



--Part II – Queries for Geography Database


SELECT PeakName FROM Peaks ORDER BY PeakName ASC --22. All Mountain Peaks

SELECT TOP(30) CountryName,Population 
  FROM Countries
 WHERE ContinentCode = (SELECT ContinentCode FROM Continents
 WHERE ContinentName = 'Europe')
 ORDER BY Population DESC,CountryName   --23. Biggest Countries by Population



 SELECT CountryName, CountryCode, 
	CASE WHEN CurrencyCode = 'EUR' 
		THEN 'Euro' 
		ELSE 'Not Euro'
	END AS [Currency]
FROM Countries ORDER BY CountryName ASC --24. Countries and Currency (Euro / Not Euro)




--Part III – Queries for Diablo Database

SELECT [Name] 
  FROM Characters
 ORDER BY [Name]