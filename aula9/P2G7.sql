---Creation Script)
Create schema Empresa;
GO

CREATE TABLE Empresa.EMPLOYEE (
	Fname   VARCHAR(15)     NOT NULL,
	Minit   CHAR,
	Lname   VARCHAR(15)     NOT NULL,
	Ssn     CHAR(9)         NOT NULL,
	Bdate   DATE,
	Address VARCHAR(30),
	Sex     CHAR,
	Salary  DECIMAL(10,2),
	Super_ssn CHAR(9),
	Dno     INT             NOT NULL,
	PRIMARY KEY (Ssn),
);

CREATE TABLE Empresa.DEPARTMENT (
	Dname   VARCHAR(15)     NOT NULL,
	Dnumber INT             NOT NULL,
	Mgr_ssn CHAR(9),
	Mgr_start_date DATE,
	PRIMARY KEY (Dnumber),
	UNIQUE (Dname),
);

CREATE TABLE Empresa.DEPENDENT(
	Essn    CHAR(9)         NOT NULL,
	Dependent_name VARCHAR(15) NOT NULL,
	Sex     CHAR,
	Bdate   DATE,
	Relationship VARCHAR(8),
	PRIMARY KEY (Essn, Dependent_name),
);

CREATE TABLE Empresa.DEPT_LOCATIONS(
	Dnumber INT             NOT NULL,
	Dlocation VARCHAR(15)   NOT NULL,
	PRIMARY KEY (Dnumber, Dlocation), 
);

CREATE TABLE Empresa.PROJECT(
	Pname   VARCHAR(15)     NOT NULL,
	Pnumber INT             NOT NULL,
	Plocation VARCHAR(15),
	Dnum    INT             NOT NULL,
	PRIMARY KEY (Pnumber),
	UNIQUE (Pname),
);

CREATE TABLE Empresa.WORKS_ON(
	Essn    CHAR(9)         NOT NULL,
	Pno     INT             NOT NULL,
	Hours   DECIMAL(3,1)    NOT NULL,
	PRIMARY KEY (Essn, Pno),
);


ALTER TABLE Empresa.EMPLOYEE ADD CONSTRAINT employeeDep FOREIGN KEY (Dno) REFERENCES Empresa.DEPARTMENT (Dnumber);
ALTER TABLE Empresa.EMPLOYEE ADD CONSTRAINT employeeSuperSsn FOREIGN KEY (Super_ssn) REFERENCES Empresa.EMPLOYEE (Ssn);
ALTER TABLE Empresa.DEPT_LOCATIONS ADD CONSTRAINT deptLocDnum FOREIGN KEY (Dnumber) REFERENCES Empresa.DEPARTMENT (Dnumber);
ALTER TABLE Empresa.PROJECT ADD CONSTRAINT projDnum FOREIGN KEY (Dnum) REFERENCES Empresa.DEPARTMENT (Dnumber);
ALTER TABLE Empresa.WORKS_ON ADD CONSTRAINT worksProj FOREIGN KEY (Pno) REFERENCES Empresa.PROJECT (Pnumber);
ALTER TABLE Empresa.WORKS_ON ADD CONSTRAINT worksEmp FOREIGN KEY (Essn) REFERENCES Empresa.EMPLOYEE (Ssn);
ALTER TABLE Empresa.DEPENDENT ADD CONSTRAINT dependentEmp FOREIGN KEY (Essn) REFERENCES Empresa.EMPLOYEE (Ssn);

/** b) Introduza dados nas bases de dados criadas. Sugere-se que utilize o dataset fornecido
na última aula (disponível no Moodle); **/

INSERT INTO Empresa.DEPARTMENT(Dname,Dnumber,Mgr_ssn,Mgr_start_date)VALUES('Investigacao',1,21312332,'2010-08-02')
INSERT INTO Empresa.DEPARTMENT(Dname,Dnumber,Mgr_ssn,Mgr_start_date)VALUES('Comercial',2,321233765,'2013-05-16')
INSERT INTO Empresa.DEPARTMENT(Dname,Dnumber,Mgr_ssn,Mgr_start_date)VALUES('Logistica',3,41124234,'2013-05-16')
INSERT INTO Empresa.DEPARTMENT(Dname,Dnumber,Mgr_ssn,Mgr_start_date)VALUES('RecursosHumanos',4,12652121,'2014-04-02')


INSERT INTO Empresa.EMPLOYEE(Fname,Minit,Lname,Ssn,Bdate,Address,Sex,Salary,Super_ssn,Dno)VALUES('Paula','A','Sousa',183623612,'2001-08-11','Rua da FRENTE','F',1450.00,NULL,3)
INSERT INTO Empresa.EMPLOYEE(Fname,Minit,Lname,Ssn,Bdate,Address,Sex,Salary,Super_ssn,Dno)VALUES('Carlos','D','Gomes',21312332,'2000-01-01','Rua XPTO','M',1200.00,NULL,1)
INSERT INTO Empresa.EMPLOYEE(Fname,Minit,Lname,Ssn,Bdate,Address,Sex,Salary,Super_ssn,Dno)VALUES('Juliana','A','Amaral',321233765,'1980-08-11','Rua BZZZZ','F',1350.00,NULL,3)
INSERT INTO Empresa.EMPLOYEE(Fname,Minit,Lname,Ssn,Bdate,Address,Sex,Salary,Super_ssn,Dno)VALUES('Maria','I','Pereira',342343434,'2001-05-01','Rua JANOTA','F',1250.00,21312332,2)
INSERT INTO Empresa.EMPLOYEE(Fname,Minit,Lname,Ssn,Bdate,Address,Sex,Salary,Super_ssn,Dno)VALUES('Joao','G','Costa',41124234,'2001-01-01','Rua YGZ','M',1300.00,21312332,2)
INSERT INTO Empresa.EMPLOYEE(Fname,Minit,Lname,Ssn,Bdate,Address,Sex,Salary,Super_ssn,Dno)VALUES('Ana','L','Silva',12652121,'1990-03-03','Rua ZIG ZAG','F',1400.00,21312332,2)


INSERT INTO Empresa.DEPENDENT(Essn,Dependent_name,Sex,Bdate,Relationship)VALUES(21312332,'Joana Costa','F','2008-04-01','Filho')
INSERT INTO Empresa.DEPENDENT(Essn,Dependent_name,Sex,Bdate,Relationship)VALUES(21312332,'Maria Costa','F','1990-10-05','Neto')
INSERT INTO Empresa.DEPENDENT(Essn,Dependent_name,Sex,Bdate,Relationship)VALUES(21312332,'Rui Costa','M','2000-08-04','Neto')
INSERT INTO Empresa.DEPENDENT(Essn,Dependent_name,Sex,Bdate,Relationship)VALUES(321233765,'Filho Lindo','M','2001-02-22','Filho')
INSERT INTO Empresa.DEPENDENT(Essn,Dependent_name,Sex,Bdate,Relationship)VALUES(342343434,'Rosa Lima','F','2006-03-11','Filho')
INSERT INTO Empresa.DEPENDENT(Essn,Dependent_name,Sex,Bdate,Relationship)VALUES(41124234,'Ana Sousa','F','2007-04-13','Neto')
INSERT INTO Empresa.DEPENDENT(Essn,Dependent_name,Sex,Bdate,Relationship)VALUES(41124234,'Gaspar Pinto','M','2006-02-08','Sobrinho')

INSERT INTO Empresa.DEPT_LOCATIONS(Dnumber,Dlocation)VALUES(2,'Aveiro')
INSERT INTO Empresa.DEPT_LOCATIONS(Dnumber,Dlocation)VALUES(3,'Coimbra')

INSERT INTO Empresa.PROJECT(Pname,Pnumber,Plocation,Dnum)VALUES('Aveiro Digital',1,'Aveiro',3)
INSERT INTO Empresa.PROJECT(Pname,Pnumber,Plocation,Dnum)VALUES('BD Open Day',2,'Espinho',2)
INSERT INTO Empresa.PROJECT(Pname,Pnumber,Plocation,Dnum)VALUES('Dicoogle',3,'Aveiro',3)
INSERT INTO Empresa.PROJECT(Pname,Pnumber,Plocation,Dnum)VALUES('GOPACS',4,'Aveiro',3)

INSERT INTO Empresa.WORKS_ON(Essn,Pno,Hours)VALUES(183623612,1,20.0)
INSERT INTO Empresa.WORKS_ON(Essn,Pno,Hours)VALUES(183623612,3,10.0)
INSERT INTO Empresa.WORKS_ON(Essn,Pno,Hours)VALUES(21312332,1,20.0)
INSERT INTO Empresa.WORKS_ON(Essn,Pno,Hours)VALUES(321233765,1,25.0)
INSERT INTO Empresa.WORKS_ON(Essn,Pno,Hours)VALUES(342343434,1,20.0)
INSERT INTO Empresa.WORKS_ON(Essn,Pno,Hours)VALUES(342343434,4,25.0)
INSERT INTO Empresa.WORKS_ON(Essn,Pno,Hours)VALUES(41124234,2,20.0)
INSERT INTO Empresa.WORKS_ON(Essn,Pno,Hours)VALUES(41124234,3,30.0)
--- a)
DROP PROC a;
GO
CREATE PROC a (@numero int) AS 
	BEGIN
		Delete from Empresa.DEPENDENT where Essn=@numero;
		Delete from Empresa.WORKS_ON where Essn=@numero;
		Delete from Empresa.EMPLOYEE where Ssn=@numero;
	END
GO
--teste- eliminou Paula Sousa
SELECT Ssn, Fname, Lname, Pno FROM (Empresa.WORKS_ON JOIN Empresa.EMPLOYEE ON Essn=Ssn);
EXEC a '183623612'

SELECT Ssn, Fname, Lname, Pno FROM (Empresa.WORKS_ON JOIN Empresa.EMPLOYEE ON Essn=Ssn);

--- b)
DROP TABLE Deleted_Depa;
DROP TRIGGER Empresa.h_after;
DROP PROC b;
DROP TRIGGER Empresa.d;

GO
CREATE PROC b
	@Oldssn INT OUTPUT,
	@Oldyear INT OUTPUT
AS
BEGIN
	SELECT Fname, Minit, Lname, Ssn, Salary, Dno, Mgr_start_date FROM Empresa.EMPLOYEE, Empresa.Department WHERE Mgr_ssn = Ssn;

	SELECT TOP(1) @Oldssn = Ssn, @Oldyear = YEAR(Mgr_start_date) FROM Empresa.EMPLOYEE, Empresa.Department WHERE Mgr_ssn = Ssn ORDER BY Mgr_start_date;
END
GO

--Teste
DECLARE @Oldssn INT, @Oldyear INT;
EXEC b @Oldssn OUTPUT, @Oldyear OUTPUT;
PRINT @Oldssn;
PRINT @Oldyear;

---c)
DROP TRIGGER Empresa.c; 
GO
CREATE Trigger Empresa.c ON Empresa.DEPARTMENT 
AFTER INSERT,UPDATE
AS
	SET NOCOUNT ON;
	DECLARE @ssn CHAR(9);
	SELECT @ssn=Mgr_ssn FROM inserted;

	IF EXISTS( SELECT Mgr_ssn FROM Empresa.DEPARTMENT WHERE Mgr_ssn=@ssn )
	BEGIN
		RAISERROR ('O funcionario só pode ser gestor de um departamento.', 16,1);
		ROLLBACK TRAN;
	END
GO

--teste tenta colocar o 21312332 como gestor de outro dep

SELECT * FROM Empresa.DEPARTMENT;
UPDATE Empresa.DEPARTMENT SET Mgr_ssn='21312332' WHERE Dnumber=2;
SELECT * FROM Empresa.DEPARTMENT;

--- d)

GO

CREATE TRIGGER Empresa.d ON Empresa.EMPLOYEE
AFTER INSERT, UPDATE
AS
BEGIN
	DECLARE @Salary AS INT;
	DECLARE @MgrSalary AS INT;
	DECLARE @Ssn AS INT;
	DECLARE @Dno AS INT;
	DECLARE @Mgr_ssn AS INT;

	SELECT @Ssn=inserted.Ssn, @Salary=inserted.Salary, @Dno=inserted.Dno FROM inserted;

	SELECT @Mgr_Ssn = Mgr_ssn, @Salary = Salary FROM Empresa.EMPLOYEE, Empresa.DEPARTMENT WHERE @Dno = Dnumber AND @Ssn = Ssn;

	SELECT @MgrSalary = Salary FROM Empresa.EMPLOYEE WHERE Ssn = @Mgr_Ssn;
	
	IF @Salary > @MgrSalary
	BEGIN
		UPDATE Empresa.EMPLOYEE SET Salary=@MgrSalary-1 WHERE Ssn=@Ssn;
	END
END

GO

-- Teste

DELETE FROM Empresa.EMPLOYEE WHERE EMPLOYEE.Ssn=345332112;
UPDATE Empresa.EMPLOYEE SET Salary=3000 WHERE Ssn=342343434;
SELECT * FROM Empresa.EMPLOYEE;
DELETE FROM Empresa.EMPLOYEE WHERE EMPLOYEE.Ssn=345332112;

---e)
DROP FUNCTION Empresa.e;
GO
CREATE FUNCTION	Empresa.e (@ssn CHAR(9)) RETURNS TABLE
AS
	RETURN( SELECT PName, PLocation FROM ((Empresa.EMPLOYEE join Empresa.WORKS_ON ON employee.Ssn=works_on.Essn) JOIN Empresa.PROJECT ON Pno=project.PNumber) WHERE Ssn=@ssn)
GO

--teste -- retorna os projetos em que carlos D gomes trabalha

SELECT Pname,Plocation FROM Empresa.e('21312332');
SELECT * FROM Empresa.EMPLOYEE
SELECT * FROM Empresa.PROJECT

--f)

DROP FUNCTION f;
GO
CREATE FUNCTION f (@dno INT) RETURNS @table TABLE
	(Fname  VARCHAR(30),
	 Lname  VARCHAR(30),
	 Ssn    CHAR(10),
	 Salary DECIMAL(9,2))
AS
BEGIN
	INSERT @table
		SELECT Fname, Lname, Ssn, Salary FROM Empresa.EMPLOYEE JOIN(SELECT Dno, AVG(Salary) as avg_salary FROM Empresa.Department, Empresa.EMPLOYEE WHERE Dno = Dnumber GROUP BY Dno) AS Sal_Dep
		ON Sal_Dep.Dno = EMPLOYEE.Dno AND Salary>avg_salary AND EMPLOYEE.Dno = @dno;
	RETURN;
END
GO


-- Test
SELECT * FROM f(3);
SELECT * FROM Empresa.EMPLOYEE;

---g)
DROP FUNCTION employeeDeptHighAverage;
GO

CREATE FUNCTION	employeeDeptHighAverage (@dno int) returns @DeptHiTable Table(pname varchar(20), pnumber int, plocation varchar(20), dnum int, budget decimal(10,2), totalbudget decimal(10,2))
AS BEGIN

	DECLARE @name AS VARCHAR(20);
	DECLARE @number AS INT;
	DECLARE @location AS VARCHAR(20);
	DECLARE @dnumber AS INT;
	DECLARE @bud AS DECIMAL(10,2);
	DECLARE @totalbud AS DECIMAL(10,2);

	DECLARE Crs CURSOR 
	FOR SELECT Pname, PNumber, PLocation FROM Empresa.PROJECT WHERE DNum=@dno; 
	SET @totalbud=0;

	OPEN Crs;

	FETCH FROM Crs INTO @name, @number, @location;
	While @@FETCH_STATUS=0 BEGIN
		Select @bud = SUM((Empresa.WORKS_ON.Hours/40)*Empresa.EMPLOYEE.Salary) from (Empresa.WORKS_ON join Empresa.EMPLOYEE on Empresa.WORKS_ON.Essn=Empresa.EMPLOYEE.Ssn) where Empresa.WORKS_ON.Pno=@number;
		
		SET @totalbud+=@bud
		Insert @DeptHiTable(pname, pnumber, plocation, dnum, budget, totalbudget) values(@name, @number,@location, @dno, @bud, @totalbud)
	
		FETCH FROM Crs INTO @name, @number, @location;
	END

	CLOSE Crs;
	DEALLOCATE Crs;

	RETURN 
END
GO

--teste -- exemplo dado
SELECT * FROM employeeDeptHighAverage(3);

--h)

--Instead

DROP TRIGGER Empresa.h_instead;
--SELECT * FROM DEPARTMENT;
SELECT * FROM Empresa.EMPLOYEE;
GO
CREATE TRIGGER Empresa.h_instead ON Empresa.DEPARTMENT
after insert
AS
		BEGIN
			DECLARE @Dname VARCHAR(30);
			DECLARE @Dnumber int;
			DECLARE @Mgr_ssn int;
			DECLARE @Mgr_start_date date;

			SELECT @Dname = Dname FROM deleted;
			SELECT @Dnumber = Dnumber FROM deleted;
			SELECT @Mgr_ssn = Mgr_ssn FROM deleted;
			SELECT @Mgr_start_date = Mgr_start_date FROM deleted;

			IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
				WHERE TABLE_SCHEMA = 'Empresa' AND TABLE_NAME = 'Deleted_Dep'))
				CREATE TABLE Deleted_Dep (Dname VARCHAR(30), Dnumber int, Mgr_ssn int NULL, Mgr_start_date date NULL);
			INSERT INTO Deleted_Dep VALUES (@Dname, @Dnumber, @Mgr_ssn, @Mgr_start_date);
			DELETE FROM DEPARTMENT WHERE Dnumber = @Dnumber;
			
		END

GO
		--Teste
SELECT * FROM Empresa.DEPARTMENT;
DELETE FROM  Empresa.EMPLOYEE WHERE Ssn='3212332';
DELETE FROM  Empresa.EMPLOYEE WHERE Ssn='345355425';
INSERT INTO Empresa.EMPLOYEE(Fname,Minit,Lname,Ssn,Bdate,Address,Sex,Salary,Super_ssn,Dno)VALUES('tes','t','tes1',3212332,'2001-08-11','Rua da FRENTE','F',1450.00,NULL,3);
INSERT INTO Empresa.EMPLOYEE(Fname,Minit,Lname,Ssn,Bdate,Address,Sex,Salary,Super_ssn,Dno)VALUES('tes2','t','tes2',345355425,'2001-08-11','Rua da FRENTE','F',1450.00,NULL,3);
INSERT INTO Empresa.DEPARTMENT VALUES('Te1', 5, 3212332 , '2013-04-08');
INSERT INTO Empresa.DEPARTMENT VALUES('Te2', 6,  345355425, '2012-03-02');
DELETE FROM Empresa.DEPARTMENT WHERE Dnumber = 5;
DELETE FROM Empresa.DEPARTMENT WHERE Dnumber = 6;
SELECT * FROM Deleted_Dep;


--After
DROP TABLE Deleted_Depa;
DROP TRIGGER Empresa.h_after;
--SELECT * FROM DEPARTMENT;
--SELECT * FROM EMPLOYEE;
GO
CREATE TRIGGER Empresa.h_after ON Empresa.DEPARTMENT
AFTER DELETE
AS
		BEGIN
			DECLARE @Dname VARCHAR(30);
			DECLARE @Dnumber int;
			DECLARE @Mgr_ssn int;
			DECLARE @Mgr_start_date date;

			SELECT @Dname = Dname FROM deleted;
			SELECT @Dnumber = Dnumber FROM deleted;
			SELECT @Mgr_ssn = Mgr_ssn FROM deleted;
			SELECT @Mgr_start_date = Mgr_start_date FROM deleted;

			IF (NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES
				WHERE TABLE_SCHEMA = 'Empresa' AND TABLE_NAME = 'Deleted_Depa'))
				CREATE TABLE Deleted_Depa (Dname VARCHAR(30), Dnumber int, Mgr_ssn int NULL, Mgr_start_date date NULL);
			INSERT INTO Deleted_Depa VALUES (@Dname, @Dnumber, @Mgr_ssn, @Mgr_start_date);
		END			
GO

SELECT * FROM Empresa.DEPARTMENT;
DELETE FROM  Empresa.EMPLOYEE WHERE Ssn='3212332';
DELETE FROM  Empresa.EMPLOYEE WHERE Ssn='345355425';
INSERT INTO Empresa.EMPLOYEE(Fname,Minit,Lname,Ssn,Bdate,Address,Sex,Salary,Super_ssn,Dno)VALUES('tes','t','tes1',3212332,'2001-08-11','Rua da FRENTE','F',1450.00,NULL,3);
INSERT INTO Empresa.EMPLOYEE(Fname,Minit,Lname,Ssn,Bdate,Address,Sex,Salary,Super_ssn,Dno)VALUES('tes2','t','tes2',345355425,'2001-08-11','Rua da FRENTE','F',1450.00,NULL,3);
DELETE FROM Empresa.DEPARTMENT WHERE Dnumber = 6;
INSERT INTO Empresa.DEPARTMENT VALUES('T1', 5, 3212332 , '2013-04-08');
INSERT INTO Empresa.DEPARTMENT VALUES('T2', 6,  345355425, '2012-03-02');
DELETE FROM Empresa.DEPARTMENT WHERE Dnumber = 5;
SELECT * FROM Deleted_Depa;

/* 	
	O trigger "instead of" faz override à operação na medida em que adiciona funcionalidades extra à mesma.
	O trigger after é disparado após a operação e faz o que foi especificado.
	Devemos utilizar o tipo de trigger "instead of" quando sabemos que existe uma probabilidade elevada de ser rolled back e pretendemos que não seja executada para 
evitar perdas de performance. Devemos usar o tipo trigger after quando a probabilidade de ser rolled back é baixa.
*/

---i)
/*
Stored procedure vantagens:
	- O SQL Server não tem de recompilar o código cada vez que o procedimento é invocado.
	- Execução mais rápida poruqe Os procedimento são guardados em memória cache na primeira vez em que são executados.
	- Usabilidade porque é mais fácil chamar um stored procedure para os programadores de aplicações do que escrever um ad hoc sql.
	- Extensibilidade porque usar stored procedures é a melhor maneira de abstrair ou desacoplar o banco de dados.
	- Integridade dos dados porque tem menor probabilidade de conter erros e é mais fácil de testar.
	- Segurança porque possui um acesso exclusivo através de stored procedures e trancando as tabelas.

UDF vantagens:
	- Os mesmos benefícios dos Stored procedures, são igualmente compilados e optimizados.
	- Oferecem os mesmo benefícios das vistas pois podem ser utilizados como fonte de dados nas consultas e nas cláusulas WHERE/HAVING. Acresce o facto de aceitar parâmetros.

Diferenças:
	- UDFs só retornam valores unicos enquanto que SPs retornam zero, unicos e valores multiplos
	- UDFs só podem ler parametros
	- SPs podem ler e devolver parametros
	- UDFs podem usar SELECT/WHERE/HAVING e SPs não podem
	
Situações:
	- Stored Prcedures:
		- Onde seja necessário um codigo SQL mais simples, limpo e optimizado com segurança extra, integridade dos dados, onde seja necessário modificar os mesmos.
	- UDFs:
		- Onde seja necessário um codigo SQL mais simples, limpo e optimizado onde seja necessário obter tabelas como parâmetros para outras operações.

*/