CREATE SCHEMA revoos
GO

CREATE TABLE revoos.Flight(
	Number			INT		NOT NULL PRIMARY KEY,
	Airlines		VARCHAR(30),
	Weekdays		TINYINT
);
CREATE TABLE revoos.Fare(
	Flight_number	INT		NOT NULL	REFERENCES	revoos.Flight(number),
	Code			INT		NOT NULL,
	Amount			DECIMAL(10,2),
	Restrictions	VARCHAR(50),
	PRIMARY KEY(Code,FLight_number)
);

CREATE TABLE revoos.Airport(
	Code			INT		NOT NULL	PRIMARY KEY,
	Name			VARCHAR(35),
	City			VARCHAR(35),
	State			VARCHAR(35)
);

CREATE TABLE revoos.Airplane_type(
	Typename		VARCHAR(30)			NOT NULL		PRIMARY KEY,
	Max_seats       SMALLINT,
	Company         VARCHAR(30)
);

CREATE TABLE revoos.Airplane(
    Airplane_number	INT		            NOT NULL	    PRIMARY KEY,
    Type			VARCHAR(30)		    REFERENCES	revoos.Airplane_type(Typename),
    total_seats		SMALLINT
);

CREATE TABLE revoos.Airport_Airplane_type(
    Airport_code         INT        NOT NULL    REFERENCES revoos.Airport(Code),
    Airplane_type        VARCHAR(30) NOT NULL    REFERENCES revoos.Airplane_type(Typename),
    PRIMARY KEY(Airport_code, Airplane_type)
);
CREATE TABLE revoos.Flight_leg(
	Leg_no               INT        NOT NULL,
    Flight_number        INT        REFERENCES revoos.Flight(Number),
    Airport_code_dep    INT        NOT NULL    REFERENCES revoos.Airport(Code),
    Airport_code_arr     INT        NOT NULL    REFERENCES revoos.Airport(Code),
    Sch_dep_time         SMALLDATETIME  NOT NULL,
    Sch_arr_time         SMALLDATETIME  NOT NULL,
    PRIMARY KEY(Leg_no,Flight_number)
);

CREATE TABLE revoos.Leg_Instance(
	Date				SMALLDATETIME		NOT NULL,
	Leg_no				INT,
	Flight_number		INT,
	Airport_code_arr		INT		NOT NULL REFERENCES revoos.Airport(Code),
	Airport_code_dep		INT		NOT NULL REFERENCES revoos.Airport(Code),
	Airplane_id			INT		REFERENCES revoos.Airplane(Airplane_number),
	Dep_time			SMALLDATETIME,
	Arr_time			SMALLDATETIME,
	No_of_avail_seats	SMALLINT,
	PRIMARY KEY(Date, Leg_no, Flight_number)
);

CREATE TABLE revoos.Seat(
	Seat_no				INT		NOT NULL,
	date				SMALLDATETIME,
	Flight_number		INT,
	Leg_no				INT,
	Customer_name		VARCHAR(35),
	Phone				CHAR(9),
	PRIMARY KEY(Seat_no, date, Flight_number, Leg_no),
	FOREIGN KEY (date,Leg_no,Flight_number) REFERENCES revoos.Leg_Instance(Date,Leg_no,Flight_number)
);



ALTER TABLE revoos.Leg_Instance  ADD FOREIGN KEY (Leg_no, Flight_number) REFERENCES revoos.Flight_Leg(Leg_no, Flight_number);

