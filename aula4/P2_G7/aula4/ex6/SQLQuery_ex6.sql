CREATE SCHEMA ATL
GO

CREATE TABLE ATL.Professor(
    Nome          VARCHAR(35),
    Morada        VARCHAR(35),
    Email         VARCHAR(35),
    Num_cc        CHAR(12)      NOT NULL,
    Data_nasc     DATE,
    Telefone      VARCHAR(9),
    Num_func      INT     NOT NULL,
    PRIMARY KEY(Num_cc)
);

CREATE TABLE ATL.Turma(
    Id           INT     NOT NULL,
    Num_max_alunos INT,
    Designacao   VARCHAR(35),
    Num_cc_prof  CHAR(12)      NOT NULL,
    PRIMARY KEY(id),
    FOREIGN KEY(Num_cc_prof) REFERENCES ATL.Professor(Num_cc)
);

CREATE TABLE ATL.Anoletivo(
    Ano         INT     NOT NULL,
    Id_turma    INT     NOT NULL,
    PRIMARY KEY(Ano, Id_turma),
    FOREIGN KEY(Id_turma) REFERENCES ATL.Turma(Id)
);

CREATE TABLE ATL.Pessoa(
    Nome          VARCHAR(35),
    Num_cc        CHAR(12)      NOT NULL,
    Morada        VARCHAR(35),
    Data_nasc     DATE,
    Telefone      VARCHAR(9),
    Email         VARCHAR(35),
    PRIMARY KEY(Num_cc)
);

CREATE TABLE ATL.Atividade(
    Id          INT     NOT NULL,
    Custo       INT     NOT NULL,
    Designacao  VARCHAR(35),
    PRIMARY KEY(Id)
);

CREATE TABLE ATL.Encarregado(
	Num_cc      CHAR(12)      NOT NULL,
    Nome        VARCHAR(35),
    Morada      VARCHAR(35),
    Data_nasc   DATE,
    Telefone    VARCHAR(9),
    Email       VARCHAR(35),
    PRIMARY KEY(Num_cc)
);


CREATE TABLE ATL.Aluno(
    Nome       VARCHAR(35),
    Morada     VARCHAR(35),
    Email      VARCHAR(35),
    Num_cc_enc CHAR(12)      NOT NULL,
    Data_nasc  DATE,
    Telefone   VARCHAR(9),
    Num_cc     CHAR(12)      NOT NULL,
    Id_turma   INT			 NOT NULL,
    PRIMARY KEY(Num_cc),
    FOREIGN KEY(Num_cc_enc) REFERENCES ATL.Encarregado(Num_cc),
    FOREIGN KEY(Id_turma) REFERENCES ATL.Turma(Id)
);

CREATE TABLE ATL.PodeFazer(
    Id_turma     INT     NOT NULL,
    Id_atividade INT     NOT NULL,
    PRIMARY KEY(Id_turma, Id_atividade),
    FOREIGN KEY(Id_turma) REFERENCES ATL.Turma(Id),
    FOREIGN KEY(Id_atividade) REFERENCES ATL.Atividade(Id)
);

CREATE TABLE ATL.Faz(
    Id_atividade INT     NOT NULL,
    Num_cc_aluno CHAR(12)      NOT NULL,
    PRIMARY KEY(Id_atividade, Num_cc_aluno),
    FOREIGN KEY(Id_atividade) REFERENCES ATL.Atividade(Id),
    FOREIGN KEY(Num_cc_aluno) REFERENCES ATL.Aluno(Num_cc)
);

CREATE TABLE ATL.Autorizada(
    Num_cc_pessoa CHAR(12)      NOT NULL,
    Num_cc_aluno  CHAR(12)      NOT NULL,
    PRIMARY KEY(Num_cc_pessoa, Num_cc_aluno),
    FOREIGN KEY(Num_cc_pessoa) REFERENCES ATL.Pessoa(Num_cc),
    FOREIGN KEY(Num_cc_aluno) REFERENCES ATL.Aluno(Num_cc)
);