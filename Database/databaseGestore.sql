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

insert into gestore (ID, username, password_, tipoArea,IDarea) values (default, 'gestore1', 'op0001', 'edificio', 1);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (default, 'gestore2', 'op0002', 'edificio', 2);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (default, 'gestore3', 'op0003', 'città', 1);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (default, 'gestore4', 'op0004', 'zona', 1);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (default, 'gestore5', 'op0005', 'zona', 2);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (default, 'gestore6', 'op0006', 'città', 2);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (default, 'gestore7', 'op0007', 'zona', 3);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (default, 'gestore8', 'op0008', 'città', 3);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (default, 'gestore9', 'op0009', 'edificio', 3);
insert into gestore (ID, username, password_, tipoArea,IDarea) values (default, 'gestore10', 'op0010', 'edificio', 4);

select * from gestore