USE MesaAyuda

INSERT INTO AREAS VALUES
('ADMINISTRATIVA',NULL),
('INFORMÁTICA',NULL),
('GESTIÓN HUMANA',NULL),
('MANTENIMIENTO',NULL),
('CONTABILIDAD',NULL)


INSERT INTO EMPLOYEES VALUES
('Hugo','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\fotos\\1.jpg','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\hvs\\1.pdf','411','hugo@ma.com','Cl. 54a #30-01, Medellín, Antioquia',-75.5532407,6.2453253,NULL,NULL),
('Paco','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\fotos\\2.jpg','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\hvs\\2.pdf','412','paco@ma.com','Cra. 74d #732, Medellín, Antioquia',-75.5910024,6.2736935,NULL,NULL),
('Luís','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\fotos\\3.jpg','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\hvs\\3.pdf','413','luis@ma.com','Cra. 65 #98 A-75, Medellín, Antioquia',-75.5715315,6.2938986,NULL,NULL),
('Ana','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\fotos\\4.jpg','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\hvs\\4.pdf','414','ana@ma.com','Cra. 51 #58-69, Medellín, Antioquia',-75.5683161,6.2576409,NULL,NULL),
('Lina','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\fotos\\5.jpg','C:\\xampp\\htdocs\\proyectoMesaAyuda\\vista\\hvs\\5.pdf','415','lina@ma.com','Cl. 47A ##85 - 20, Medellín, Antioquia',-75.6026462,6.2504554,NULL,NULL)

SELECT * FROM EMPLOYEES
SELECT * FROM AREAS

UPDATE EMPLOYEES SET FKEMPLOYEEBOSS = 1 WHERE IDEMPLOYEE BETWEEN 2 AND 5
UPDATE AREAS SET FKEMPLOYEE = 1 WHERE IDAREA = 1
UPDATE AREAS SET FKEMPLOYEE = 2 WHERE IDAREA = 5
UPDATE AREAS SET FKEMPLOYEE = 3 WHERE IDAREA = 3
UPDATE AREAS SET FKEMPLOYEE = 4 WHERE IDAREA = 2
UPDATE AREAS SET FKEMPLOYEE = 5 WHERE IDAREA = 4
UPDATE EMPLOYEES SET FKAREA = 1 WHERE IDEMPLOYEE = 1
UPDATE EMPLOYEES SET FKAREA = 5 WHERE IDEMPLOYEE = 2
UPDATE EMPLOYEES SET FKAREA = 3 WHERE IDEMPLOYEE = 3
UPDATE EMPLOYEES SET FKAREA = 2 WHERE IDEMPLOYEE = 4
UPDATE EMPLOYEES SET FKAREA = 4 WHERE IDEMPLOYEE = 5

SELECT Employees.Id AS IDEMPLE, Employees.Name AS EMPLENAME, Areas.Name AS AREA
FROM Areas
INNER JOIN Employees
ON Areas.fk_Employee = Employees.Id
