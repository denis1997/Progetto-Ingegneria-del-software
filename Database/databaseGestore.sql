drop database if exists databaseGestore;

create database databaseGestore;
use databaseGestore;

create table gestore(
	ID integer unsigned not null primary key auto_increment,
    username varchar(20)not null unique,
    password_ varchar(20)not null,
    tipoArea enum ('citta','zona','edificio')not null,
    IDArea integer unsigned not null
);

insert into gestore (ID, username, password_, tipoArea,IDarea) values (0001, 'gestore1', 'op0001', 'edificio', 01);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (0002, 'gestore2', 'op0002', 'edificio', 01);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (0003, 'gestore3', 'op0003', 'città', 02);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (0004, 'gestore4', 'op0004', 'zona', 03);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (0005, 'gestore5', 'op0005', 'zona', 03);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (0006, 'gestore6', 'op0006', 'città', 02);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (0007, 'gestore7', 'op0007', 'zona', 03);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (0008, 'gestore8', 'op0008', 'città', 02);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (0009, 'gestore9', 'op0009', 'edificio', 01);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (0010, 'gestore10', 'op0010', 'edificio', 01);

select * from gestore