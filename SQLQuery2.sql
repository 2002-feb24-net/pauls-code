create schema ppl
go

create table ppl.Department (
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	Name NVARCHAR(100) not null,
	Location nvarchar(100) null
)

create table ppl.Employee	 (
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(500) not null,
	LastName nvarchar(50) not null,
	SSN int UNIQUE,
	DeptID int FOREIGN KEY REFERENCES ppl.Department(ID)
)

create table ppl.EmployeeDetails	 (
	Id INT NOT NULL PRIMARY KEY IDENTITY,
	EmployeeID int FOREIGN KEY REFERENCES ppl.Employee(ID),
	Salary int null,
	"Address 1" nvarchar(100) null,
	"Address 2" nvarchar(100) null,
	City nvarchar(50) null,
	State nvarchar(50) null,
	Country nvarchar(50) not null,
)


INSERT INTO ppl.Department(name, location) VALUES
	('Marketing', '1st Flr')
INSERT INTO ppl.Department(name, location) VALUES
	 ('Sales', '2nd Flr')
INSERT INTO ppl.Department(name, location) VALUES
	  ('HR', '3rd Flr');

INSERT INTO ppl.employee (firstName, lastname, ssn, deptid) VALUES
	('Tina', 'Smith', 123456789, (SELECT Id FROM ppl.department WHERE name = 'Marketing'));

INSERT INTO ppl.employee (firstName, lastname, ssn, deptid) VALUES
	('David', 'Prendiville', 234567890, (SELECT Id FROM ppl.department WHERE name = 'Sales'));

INSERT INTO ppl.employee (firstName, lastname, ssn, deptid) VALUES
	('Catbert', 'Adams', 345678901, (SELECT Id FROM ppl.department WHERE name = 'HR'));

INSERT INTO ppl.employeedetails (employeeid, salary, "Address 1", city, state, country) VALUES
	((SELECT Id FROM ppl.employee WHERE lastname = 'smith'), 90000, '123 Main st', 'Springfield', 'Texas', 'USA');

INSERT INTO ppl.employeedetails (employeeid, salary, "Address 1", city, state, country) VALUES
	((SELECT Id FROM ppl.employee WHERE firstname = 'david'), 120000, '1440 Drury ln', 'Leominster', 'Massachusetts', 'USA');

INSERT INTO ppl.employeedetails (employeeid, salary, "Address 1", city, state, country) VALUES
	((SELECT Id FROM ppl.employee WHERE firstname = 'catbert'), 80000, '666 Hobo Row', 'Los Angeles', 'California', 'USA');

INSERT INTO ppl.employee (firstName, lastname, ssn, deptid) VALUES
	('Don', 'Draper', 456789012, (SELECT Id FROM ppl.department WHERE name = 'Marketing'));

INSERT INTO ppl.employeedetails (employeeid, salary, "Address 1", city, state, country) VALUES
((SELECT Id FROM ppl.employee WHERE firstname = 'don'), 150000, '1 Madison Ave', 'New York', 'New York', 'USA');