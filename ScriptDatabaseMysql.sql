CREATE DATABASE empresa;

USE empresa;

-- Criação da tabela Diretor
CREATE TABLE Diretor (
    diretor_id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    telefone VARCHAR(20) NOT NULL,
    idade INT NOT NULL,
    cpf VARCHAR(14) NOT NULL
);

-- Criação da tabela Gerentes
CREATE TABLE Gerentes (
    gerente_id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    diretor_id INT,
    equipe_id INT,  -- Adicionando um campo para a equipe do gerente
    UNIQUE KEY (equipe_id)  -- Garantindo que um gerente tenha apenas uma equipe
);

-- Criação da tabela Equipes
CREATE TABLE Equipes (
    equipe_id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    gerente_id INT,
    FOREIGN KEY (gerente_id) REFERENCES Gerentes(gerente_id)
);

-- Criação da tabela Funcionário
CREATE TABLE Funcionario (
    funcionario_id INT AUTO_INCREMENT PRIMARY KEY,
    nome VARCHAR(255) NOT NULL,
    equipe_id INT,
    gerente_id INT,
    FOREIGN KEY (equipe_id) REFERENCES Equipes(equipe_id),
    FOREIGN KEY (gerente_id) REFERENCES Gerentes(gerente_id)
);

-- Inserção de um exemplo de Dono
INSERT INTO Diretor (nome, email, telefone, idade, cpf) VALUES
    ('Francisco', 'diretor@example.com', '(123) 456-7890', 45, '123.456.789-01');

-- Inserir Gerentes e relacionar com Dono
INSERT INTO Gerentes (nome, diretor_id, equipe_id) VALUES
    ('Alice', 1, 1),
    ('Bob', 2, 2);

-- Inserir Equipes e relacionar com Gerentes
INSERT INTO Equipes (nome, gerente_id) VALUES
    ('Vendas', 1),
    ('Desenvolvimento', 2);

-- Inserir Funcionários e relacionar com Equipes e Gerentes
INSERT INTO Funcionario (nome, equipe_id, gerente_id) VALUES
    ('Carol', 1, 1),
    ('David', 1, 1),
    ('Emily', 2, 2),
    ('Frank', 2, 2),
    ('Grace', 1, 1),
    ('Henry', 2, 2);
    
SELECT * FROM Diretor;
SELECT * FROM Gerentes;
SELECT * FROM Equipes;
SELECT * FROM Funcionario;