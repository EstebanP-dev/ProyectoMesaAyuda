INSERT INTO Areas(Id, Name, fk_Employee) VALUES
('10','INFORMÁTICA',NULL),
('20','GESTIÓN HUMANA',NULL),
('30','MANTENIMIENTO',NULL),
('40','CONTABILIDAD',NULL)

INSERT INTO Employees(Id,Name,Photo,Employee_CV,Telephone,Email,Address,Cord_X,Cord_Y,fk_EmployeeBoss,fk_Area) VALUES
('1','Hugo','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\fotos\\1.jpg','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\hvs\\1.pdf','411','hugo@ma.com','Cl. 54a #30-01, Medellín, Antioquia',-75.5532407,6.2453253,null,10),
('2','Paco','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\fotos\\2.jpg','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\hvs\\2.pdf','412','paco@ma.com','Cra. 74d #732, Medellín, Antioquia',-75.5910024,6.2736935,null,10),
('3','Luís','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\fotos\\3.jpg','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\hvs\\3.pdf','413','luis@ma.com','Cra. 65 #98 A-75, Medellín, Antioquia',-75.5715315,6.2938986,null,20),
('4','Ana','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\fotos\\4.jpg','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\hvs\\4.pdf','414','ana@ma.com','Cra. 51 #58-69, Medellín, Antioquia',-75.5683161,6.2576409,null,10),
('5','Lina','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\fotos\\5.jpg','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\hvs\\5.pdf','415','lina@ma.com','Cl. 47A ##85 - 20, Medellín, Antioquia',-75.6026462,6.2504554,null,30)

SELECT * FROM Employees
SELECT * FROM Areas

UPDATE Employees SET fk_EmployeeBoss = '4' WHERE Id BETWEEN 1 AND 2
UPDATE Employees SET fk_EmployeeBoss = '3' WHERE Id BETWEEN 3 AND 5
UPDATE Areas SET fk_Employee = '2' WHERE Id = '10'
UPDATE Areas SET fk_Employee = '5' WHERE Id = '20'
UPDATE Areas SET fk_Employee = '1' WHERE Id = '30'
UPDATE Areas SET fk_Employee = '4' WHERE Id = '40'

SELECT Employees.Id AS IDEMPLE, Employees.Name AS EMPLENAME, Areas.Name AS AREA
FROM Areas
INNER JOIN Employees
ON Areas.fk_Employee = Employees.Id
