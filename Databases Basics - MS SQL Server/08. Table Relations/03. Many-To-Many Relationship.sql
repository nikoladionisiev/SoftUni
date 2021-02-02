USE [Many-To-Many Relationship]

CREATE TABLE Students(
	StudentID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[Name] NVARCHAR(20) NOT NULL
 )

 CREATE TABLE Exams(
	ExamID INT PRIMARY KEY IDENTITY(101,1) NOT NULL,
	[Name] NVARCHAR(20) NOT NULL
 )

 CREATE TABLE StudentsExams(
	StudentID INT NOT NULL FOREIGN KEY REFERENCES Students(StudentID),
	ExamID INT NOT NULL FOREIGN KEY REFERENCES Exams(ExamID)
	PRIMARY KEY(StudentID, ExamID)
 )

 INSERT INTO Students([Name]) VALUES
	('Mila'),
	('Toni'),
	('Ron')

INSERT INTO Exams([Name]) VALUES
	('SpringMVC'),
	('Neo4j'),
	('Oracle 11g')

INSERT INTO StudentsExams(StudentID, ExamID) VALUES
	(1, 101),
	(1, 102),
	(2, 101),
	(3, 103),
	(2, 102),
	(2, 103)