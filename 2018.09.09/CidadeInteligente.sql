USE MASTER
DROP DATABASE CidadeInteligente

CREATE DATABASE CidadeInteligente
GO

USE CidadeInteligente
GO

CREATE TABLE tb_pessoa(
	idPessoa int primary key identity (1,1),
	nmPessoa varchar (200),
	dsEndereco varchar (300),
	dsEstadoCivil char (12),
	dtDataNascimento date
)
GO

insert into tb_pessoa(nmPessoa, dsEndereco, dsEstadoCivil, dtDataNascimento) values
('Richard de Oliveira Lopes','Rua Pedro 21','Solteiro','2001-07-30'),
('Denise Rocha','Rua Dilmaputa 90','Solteiro','2000-05-15'),
('Lucas Negro','Rua Pito 24','Solteiro','1991-02-11'),
('Hebert Raimundo','Rua Pedro 26','Solteiro','1997-07-31'),
('Caio de sál','Rua Vinicius 21','Solteiro','1990-06-10'),
('Matheus Duro','Rua Bolsonaro 17','Solteiro','1967-08-28')

CREATE TABLE tb_pessoaDocumento(
	idPessoaDocumento int primary key identity (1,1),
	idPessoa int foreign key references tb_pessoa (idPessoa),
	nrRg char (10),
	nrCpf char (12),
	nrReservista char (12),
	nrCarteiraTrabalho char (8),
	nrCnh char (11)
)
GO

insert into tb_pessoaDocumento(idPessoa, nrRg, nrCpf, nrCarteiraTrabalho, nrReservista, nrCnh) values
(1,'165','487','846','856','201'),
(2,'255','257','846','877','895'),
(3,'857','479','846','896','568'),
(4,'986','036','285','846','759'),
(5,'982','421','765','846','434'),
(6,'432','846','679','693','123')

CREATE TABLE tb_funcionario(
	idFuncionario int primary key identity (1,1),
	idPessoa int foreign key references tb_pessoa (idPessoa),
	nmCargo varchar (100),
	nrSalario decimal(38),
	nrRamal char (6)
)
GO

insert into tb_funcionario(idPessoa, nmCargo, nrSalario, nrRamal) values
(1,'Gerente','1856.48','545'),
(2,'Gerente','1857.48','545'),
(3,'Gerente','1856.48','545')

CREATE TABLE tb_cliente(
	idCliente int primary key identity (1,1),
	idPessoa int foreign key references tb_pessoa (idPessoa),
	dtInclusão date
)
GO

insert into tb_cliente(idPessoa, dtInclusão) values
(4,'2018-05-09'),
(5,'2018-05-09'),
(6,'2018-05-09')