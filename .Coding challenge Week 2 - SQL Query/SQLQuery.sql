CREATE TABLE Products (
	ID INT NOT NULL PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL,
	Price MONEY NULL
);

CREATE TABLE Customers (
	ID INT NOT NULL PRIMARY KEY IDENTITY,
	Firstname NVARCHAR(20) NOT NULL,
	Lastname NVARCHAR(20) NOT NULL,
	CardNumber NVARCHAR(50) NULL,
);

CREATE TABLE Orders (
	ID INT NOT NULL PRIMARY KEY IDENTITY,
	ProductID INT NOT NULL FOREIGN KEY REFERENCES Products(ID),
	CustomerID INT NOT NULL FOREIGN KEY REFERENCES Customers(ID),
);

INSERT INTO Products (Name, Price) VALUES
('iPhone', $200),
('Galaxy S9', $300),
('Pixel 1', $400);

INSERT INTO Customers (Firstname, Lastname, CardNumber ) VALUES
('Tina', 'Smith', 1),
('David', 'Prendiville', 2),
('Dan', 'Silvestri', 3);

INSERT INTO Orders (ProductID, CustomerID ) VALUES
(1,1),
(2,2),
(1,3),
(3,1);

SELECT (c.Firstname + ' ' + c.Lastname) AS Customer, p.Name, p.Price
FROM Customers c INNER JOIN Orders o ON c.ID = o.CustomerID 
	INNER JOIN Products p ON o.ProductID = p.ID
WHERE c.ID = 1
;

SELECT SUM(p.Price) AS 'Total Revenue of iPhone Sales'
FROM Products p INNER JOIN Orders o On p.ID = o.ProductID
WHERE p.ID = 1
;

UPDATE Products SET Price =  $250
WHERE ID = 1;


