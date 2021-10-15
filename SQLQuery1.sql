CREATE TABLE Areas(
	Id VARCHAR(10) PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	fk_Employee VARCHAR(20)
)

CREATE TABLE Employees(
	Id VARCHAR(20) PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
	Photo VARCHAR(200),
	Employee_CV VARCHAR(200),
	Telephone VARCHAR(15) NOT NULL,
	Email VARCHAR(100) NOT NULL,
	Address VARCHAR(100) NOT NULL,
	Cord_X DECIMAL(10,7),
	Cord_Y DECIMAL(10,7),
	fk_EmployeeBoss VARCHAR(20),
	fk_Area VARCHAR(10),
)

ALTER TABLE Areas ADD CONSTRAINT CONSTfk_Employee 
FOREIGN KEY(fk_Employee) REFERENCES Employees(Id)

ALTER TABLE Employees ADD CONSTRAINT CONSTfk_Area 
FOREIGN KEY(fk_Area) REFERENCES Areas(Id)

ALTER TABLE Employees ADD CONSTRAINT CONSTfk_EmployeeBoss 
FOREIGN KEY(fk_EmployeeBoss) REFERENCES Employees(Id)

CREATE TABLE Status(
	Id VARCHAR(1) PRIMARY KEY,
	Name VARCHAR(16) NOT NULL,
)

CREATE TABLE Requirements(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	fk_Area VARCHAR(10) NOT NULL
)

ALTER TABLE Requirements
ADD CONSTRAINT CONSTfk_Area2 FOREIGN KEY(fk_Area) REFERENCES Areas(Id)

CREATE TABLE Requirements_Details(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Date DATETIME NOT NULL,
	Observation VARCHAR(4000) NOT NULL,
	fk_Requirement INT NOT NULL,
	fk_Status VARCHAR(1) NOT NULL,
	fk_Employee VARCHAR(20) NOT NULL,
	fk_AssignedEmployee VARCHAR(20)
)


ALTER TABLE Requirements_Details
ADD CONSTRAINT CONSTfk_Requirement FOREIGN KEY(fk_Requirement) 
REFERENCES Requirements(Id)

ALTER TABLE Requirements_Details
ADD CONSTRAINT CONSTfk_Status FOREIGN KEY(fk_Status) 
REFERENCES Status(Id)

ALTER TABLE Requirements_Details
ADD CONSTRAINT CONSTfk_Employee2 FOREIGN KEY(fk_Employee)
REFERENCES Employees(Id)

ALTER TABLE Requirements_Details
ADD CONSTRAINT CONSTfk_AssignedEmployee FOREIGN KEY(fk_AssignedEmployee)
REFERENCES Employees(Id)

CREATE TABLE Appointments(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Name VARCHAR(100) NOT NULL,
)

CREATE TABLE Appointments_Employees(
	fk_Appointment INT NOT NULL,
	fk_Employee VARCHAR(20) NOT NULL,
	Start_Date DATE NOT NULL,
	End_Date DATE,
	PRIMARY KEY(fk_Appointment,fk_Employee)
)
ALTER TABLE Appointments_Employees
ADD CONSTRAINT CONSTfk_Appointment FOREIGN KEY(fk_Appointment) 
REFERENCES Appointments(Id)

ALTER TABLE Appointments_Employees
ADD CONSTRAINT CONSTfk_Employee3 FOREIGN KEY(fk_Employee)
REFERENCES Employees(Id)