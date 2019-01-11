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

insert into `sensore` values (01,'t1');
insert into `sensore` values (02,'t2');
insert into `sensore` values (03,'u1');
insert into `sensore` values (04,'u2');
insert into `sensore` values (05,'l1');
insert into `sensore` values(06,'l2');
insert into `sensore` values (07,'p1');
insert into `sensore` values (08,'p2');

insert into `storia` values (1, '24°',t1);
insert into `storia` values (1, '10°',t2);
insert into `storia` values (1, '6°',t3);
insert into `storia` values (1, '54%',u1);
insert into `storia` values (1, '50pa',p1);
insert into `storia` values (1, '5 lux',l1);



