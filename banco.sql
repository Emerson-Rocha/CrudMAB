CREATE DATABASE  DB_PROJ;

USE DB_PROJ;

-- Funcionario 
CREATE TABLE TB_LOGIN(
ID_LOG INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
USUARIO_LOG VARCHAR(50)NOT NULL,
SENHA_LOG VARCHAR(10)NOT NULL 
);

INSERT INTO TB_LOGIN(USUARIO_LOG, SENHA_LOG)VALUES('ADMIN', '123');


create table TB_ESTADO
(
  id_est int not null primary key AUTO_INCREMENT,
  nome_est varchar(50)not null
);

insert into tb_estado(nome_est) values('Acre');
insert into tb_estado(nome_est)values('Alagoas');
insert into tb_estado(nome_est)values('Amapá');
insert into tb_estado(nome_est)values('Amazonas');
insert into tb_estado(nome_est) values('Bahia');
insert into tb_estado(nome_est) values('Ceará');
insert into tb_estado(nome_est) values('Distrito Federal');
insert into tb_estado(nome_est) values('Espírito Santo');
insert into tb_estado(nome_est) values('Goiás');
insert into tb_estado(nome_est) values('Maranhão');
insert into tb_estado(nome_est) values('Mato Grosso');
insert into tb_estado(nome_est) values('Mato Grosso do Sul');
insert into tb_estado(nome_est) values('Minas Gerais');
insert into tb_estado(nome_est) values('Pará');
insert into tb_estado(nome_est) values('Paraíba');
insert into tb_estado(nome_est) values('Paraná');
insert into tb_estado(nome_est) values('Pernambuco');
insert into tb_estado(nome_est) values('Piauí');
insert into tb_estado(nome_est) values('Rio de Janeiro');
insert into tb_estado(nome_est) values('Rio Grande do Norte');
insert into tb_estado(nome_est) values('Rio Grande do Sul');
insert into tb_estado(nome_est) values('Rondônia');
insert into tb_estado(nome_est) values('Roraima');
insert into tb_estado(nome_est) values('Santa Catarina');
insert into tb_estado(nome_est) values('São Paulo');
insert into tb_estado(nome_est) values('Sergipe');
insert into tb_estado(nome_est) values('Tocantins');


-- CLIENTE
CREATE TABLE TB_CLIENTE(
  id_cli int NOT NULL PRIMARY KEY AUTO_INCREMENT,
  nome_cli varchar(50) NOT NULL,
  end_cli varchar(50) NOT NULL,
  n_cli varchar(4) NOT NULL,
  bairro_cli varchar(50) NOT NULL,
  cidade_cli varchar(50) NOT NULL,
  id_est int NOT NULL,
  CONSTRAINT fk_EstCli FOREIGN KEY  (id_est) REFERENCES TB_ESTADO(id_est)
  )