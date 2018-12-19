drop database if exists databaseGestore;

create database databaseGestore;
use databaseGestore;

create table gestore(
	ID integer unsigned not null primary key auto_increment,
    username varchar(20)not null unique,
    password_ varchar(20)not null,
    tipoArea enum ('citta','zona','edificio')not null,
    IDArea integer unsigned not null
)