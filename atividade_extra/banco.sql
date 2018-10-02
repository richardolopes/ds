use master;
go

drop database atvextra;
go

create database atvextra;
go
use atvextra;

create table paciente (
	id int primary key identity (1,1),
	nome varchar(150),
	endereco varchar(500),
	fone nvarchar(100),
	email varchar(100)
);

insert into paciente (nome, endereco, fone, email) values
('Thiago Tiago Carlos Cavalcanti','Rua Deputado Euclides Paes Mendonça','(79) 3575-4306','thiagotiagocarloscavalcanti-79@portoweb.com.br'),
('Mateus Gabriel da Paz','Rua Tancredo Neves','(69) 2708-8948','mateusgabrieldapaz__mateusgabrieldapaz@cancaonova.com');

select * from paciente


