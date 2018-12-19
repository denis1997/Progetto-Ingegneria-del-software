drop database if exists databseHistory;

create database databaseHistory;
use databaseHistory;

create table sensore(
	ID integer unsigned not null primary key auto_increment,
    IDspecifico varchar(100) unique not null
);

create table storia(
	ID integer unsigned not null primary key auto_increment,
    valore float,
    IDsensore integer unsigned default null,
    constraint storia_esnsore foreign key(IDsensore) references sensore(ID) on update cascade

)
