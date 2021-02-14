SELECT * INTO EmployeesSalaries FROM Employees
WHERE Salary >30000

DELETE FROM EmployeesSalaries
WHERE ManagerID = 42

UPDATE EmployeesSalaries
SET Salary += 5000
WHERE DepartmentID = 1

SELECT DepartmentID ,AVG(Salary) AS AverageSalary FROM EmployeesSalaries
GROUP BY DepartmentID