CREATE SCHEMA PEM
GO

CREATE TABLE PEM.Medico(
    Num_ident     INT     NOT NULL,
    Nome          VARCHAR(35),
    Especialidade VARCHAR(35),
    PRIMARY KEY(Num_ident)
);

CREATE TABLE PEM.Paciente(
    Num_utente     INT     NOT NULL,
    Nome           VARCHAR(35),
    Data_nasc      DATE,
    Endereco       VARCHAR(35),
    PRIMARY KEY(Num_utente)
);

CREATE TABLE PEM.Farmacia(
    NIF            INT     NOT NULL,
    Nome           VARCHAR(35),
    Endereco       VARCHAR(35),
    Telefone       VARCHAR(9),
    PRIMARY KEY(NIF)
);

CREATE TABLE PEM.Prescricao(
    Num_unico      INT     NOT NULL,
	Num_iden_medico INT     NOT NULL,
	NIF_farmc      INT     NOT NULL,
    Num_utente_paciente INT     NOT NULL,
    Data           DATE,
    Processo_data  DATE,
    PRIMARY KEY(Num_unico, Num_iden_medico,NIF_farmc,Num_utente_paciente),
	unique (Num_unico),
    FOREIGN KEY(Num_iden_medico) REFERENCES PEM.Medico(Num_ident),
    FOREIGN KEY(Num_utente_paciente) REFERENCES PEM.Paciente(Num_utente),
    FOREIGN KEY(NIF_farmc) REFERENCES PEM.Farmacia(NIF)
);
CREATE TABLE PEM.Farmaceutica(
    Num_registo    INT     NOT NULL,
    Nome           VARCHAR(35),
    Endereco       VARCHAR(35),
    Telefone       VARCHAR(9),
    PRIMARY KEY(Num_registo)
);
CREATE TABLE PEM.Farmaco(
    Nome           VARCHAR(35),
    Num_reg_farm   INT     NOT NULL, 
    Formula        VARCHAR(50),
    PRIMARY KEY(Nome, Num_reg_farm),
    FOREIGN KEY(Num_reg_farm) REFERENCES PEM.Farmaceutica(Num_registo)
);

CREATE TABLE PEM.Tem(
    Farmaco_nome   VARCHAR(35),
    Prec_num_unico INT     NOT NULL,
    Farmaco_num_reg INT     NOT NULL,
    PRIMARY KEY(Farmaco_nome,Prec_num_unico, Farmaco_num_reg),
	FOREIGN KEY(Farmaco_nome, Farmaco_num_reg) REFERENCES PEM.Farmaco(Nome, Num_reg_farm),
    FOREIGN KEY(Prec_num_unico) REFERENCES PEM.Prescricao(Num_unico),
);
