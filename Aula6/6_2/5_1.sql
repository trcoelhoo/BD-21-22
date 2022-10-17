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
INSERT INTO Empresa.DEPARTMENT(Dname,Dnumber,Mgr_ssn,Mgr_start_date)VALUES('Desporto',5,NULL,NULL)

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

/** c) Converta as queries AR em queries SQL. **/

SELECT Ssn, Fname, Lname, Pno FROM (Empresa.WORKS_ON JOIN Empresa.EMPLOYEE ON Essn=Ssn);

SELECT Emp1.Fname FROM (Empresa.EMPLOYEE AS Emp1 JOIN Empresa.EMPLOYEE AS Emp2 ON Emp1.Super_ssn=Emp2.Ssn)
WHERE Emp2.Fname='Carlos' and Emp2.Lname='Gomes';

SELECT sum(Hours) AS HorasTotais, Pname FROM (Empresa.PROJECT JOIN Empresa.WORKS_ON ON Pnumber=Pno)
GROUP BY Pname;

SELECT Fname FROM (Empresa.EMPLOYEE JOIN (Empresa.PROJECT JOIN Empresa.WORKS_ON ON Pnumber=Pno) ON Ssn=Essn )
WHERE Hours > 20 and Dno = 3;

SELECT Fname FROM (Empresa.EMPLOYEE left outer JOIN Empresa.WORKS_ON ON Ssn=Essn)
WHERE Essn IS NULL

SELECT Dname, avg(Salary) AS SalarioMedioFeminino FROM (Empresa.EMPLOYEE JOIN Empresa.DEPARTMENT ON Dnumber=Dno)
WHERE Sex='F'
GROUP BY Dname;

SELECT Fname, Lname, count(Dependent_name) AS NumDeDependentes FROM (Empresa.EMPLOYEE JOIN Empresa.DEPENDENT ON Ssn=Essn)
GROUP BY Fname, Lname
HAVING count(Dependent_name) > 2;

SELECT Fname, Lname, Super_ssn, Mgr_ssn FROM (Empresa.EMPLOYEE JOIN Empresa.DEPARTMENT ON Ssn=Mgr_ssn)
WHERE Super_ssn IS NULL

SELECT Fname, ADDress FROM (((Empresa.WORKS_ON JOIN Empresa.EMPLOYEE ON Ssn=Essn) JOIN Empresa.Dept_locations ON Dno=Dnumber)JOIN Empresa.PROJECT ON Pno=Pnumber )
WHERE Dlocation!='Aveiro' and Plocation='Aveiro'