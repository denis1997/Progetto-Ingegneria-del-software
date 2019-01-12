drop database if exists databaseHistory;
						
create database databaseHistory;
use databaseHistory;

create table sensore(
	ID integer unsigned not null primary key auto_increment,
    IDspecifico varchar(100) unique not null
);

create table storia(
	ID integer unsigned not null primary key auto_increment,
    valore double,
    IDsensore integer unsigned default null,
    constraint storia_esnsore foreign key(IDsensore) references sensore(ID) on update cascade

);

insert into `sensore` values (default,'t1');
insert into `sensore` values (default,'t2');
insert into `sensore` values (default,'t3');
insert into `sensore` values (default,'t4');
insert into `sensore` values (default,'u1');
insert into `sensore` values(default,'u2');
insert into `sensore` values (default,'u3');
insert into `sensore` values (default,'l1');
insert into `sensore` values (default,'l2');




