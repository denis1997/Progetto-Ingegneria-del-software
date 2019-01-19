drop database if exists databaseSimulatore;

create database databaseSimulatore;
use databaseSimulatore;

create table sensore(
	ID integer unsigned not null primary key auto_increment,
    IDspecifico varchar(100) unique not null,
    momento smallint default 0,
    massimale double,
    min_ double,
    max_ double,
    stato smallint default 1
    );
    
insert into `sensore` values (default,'t1',0,30,20,40,default);
insert into `sensore` values (default,'t2',0,20,20,40,default);
insert into `sensore` values (default,'t3',0,40,20,40,default);
insert into `sensore` values (default,'t4',0,30,20,40,default);
insert into `sensore` values (default,'u1',0,70,0,100,default);
insert into `sensore` values(default,'u2',0,50,10,100,default);
insert into `sensore` values (default,'u3',0,60,0,100,default);
insert into `sensore` values (default,'l1',0,4000,0,10000,default);
insert into `sensore` values (default,'l2',0,6000,0,10000,default);

select * from sensore