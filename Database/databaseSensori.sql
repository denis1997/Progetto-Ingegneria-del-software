Drop database if exists databaseSensori;

create database databaseSensori;
use databaseSensori;

create table citta(
	ID integer unsigned not null primary key auto_increment,
    nome varchar(100)not null
);

create table zona(
	ID integer unsigned not null primary key auto_increment,
	nome varchar(100)not null,
	IDcitta integer unsigned not null,
    constraint zona_citta foreign key(IDcitta) references citta(ID) on update cascade on delete cascade
);

create table edificio(
	ID integer unsigned not null primary key auto_increment,
    nome varchar(100)not null,
    IDzona integer unsigned not null,
    constraint edificio_zona foreign key(IDzona) references zona(ID) on update cascade on delete cascade
);

create table sottocategorie(
	ID integer unsigned not null primary key,
	tipo varchar(10)not null
);

insert into `sottocategorie` values (1,'piazze'),(2,'parchi'),(3,'vie'),(4,'parcheggi');

create table piano(
	ID integer unsigned not null primary key auto_increment,
    nome varchar(100)not null,
	IDedificio integer unsigned not null,
    constraint piano_edificio foreign key(IDedificio) references edificio(ID) on update cascade on delete cascade
);

create table areaPiano(
	ID integer unsigned not null primary key auto_increment,
    nome varchar(100)not null,
    IDpiano integer unsigned not null,
    constraint areapiano_piano foreign key(IDpiano) references piano(ID) on update cascade on delete cascade
);

create table areaAperto(
	ID integer unsigned not null primary key auto_increment,
    nome varchar(100)not null,
    IDsottocategorie integer unsigned not null,
    IDzona integer unsigned not null,
    constraint areaAperto_sottocategoria foreign key(IDsottocategorie) references sottocategorie(ID) on update cascade,    
    constraint areaAperto_zona foreign key(IDzona) references zona(ID) on update cascade on delete cascade
);

create table sensore(
	ID integer unsigned not null primary key auto_increment,
    IDspecifico varchar(100) unique not null,
    valore double,
    state tinyint,
    oraUltimoInvio timestamp default current_timestamp,
    oraInvioPrecedente timestamp,
    IDareaAperto integer unsigned default null,
    IDareaPiano integer unsigned default null,
    constraint sensore_areaAperto foreign key(IDareaAperto) references areaAperto(ID) on update cascade on delete set null,
    constraint sensore_areaPiano foreign key(IDareaPiano) references areaPiano(ID) on update cascade on delete set null
);

create table divisioneAperto(
	IDsottocategorie integer unsigned not null,
    IDzona integer unsigned not null,
	primary key (IDsottocategorie,IDzona),
    constraint divisioneAperto_sottocategorie foreign key(IDsottocategorie) references sottocategorie(ID) on update cascade,
    constraint divisioneAperto_zone foreign key(IDzona) references zona(ID) on update cascade
);

insert into `citta` value (default,'l\'aquila');
insert into `citta` value (default,'Teramo');
insert into `citta` value (default,'Pescara');
insert into `citta` value (default,'Avezzano');
insert into `citta` value (default,'Atri');
insert into `zona` value (default,'università',1);
insert into `zona` value (default,'scuolaPrimaria',1);
insert into `zona` value (default,'ospedale',1);
insert into `edificio` value (default,'blocco 0', 1);
insert into `edificio` value (default,'blocco 1', 1);
insert into `edificio` value (default,'blocco 2', 1);
insert into `edificio` value (default,'areaMedicina', 1);
insert into `piano`value (default,'piano 1',1);
insert into `piano`value (default,'piano 2',1);
insert into `piano`value (default,'piano 3',1);

insert into `areaaperto` value(default, 'garibaldi', 1,1);
insert into `areaaperto` value(default, 'd\'annunzoio', 2,1);
insert into `areaaperto` value(default, 'vittoria',1,1);

insert into `areaPiano`value (default, 'aula 1', 1);
insert into `areaPiano`value (default, 'aula 2', 1);
insert into `areaPiano`value (default, 'aula 3', 1);
insert into `areaPiano`value (default, 'aula 4', 1);
insert into `areaPiano`value (default, 'aula 5', 1);
insert into `areaPiano`value (default, 'aula 6', 1);
/*insert into `areaPiano`value (default, 'corridoio 1', 1);*/
insert into `areaPiano`value (default, 'corridoio 2', 1);
insert into `areaPiano`value (default, 'aula 1', 2);
insert into `areaPiano`value (default, 'aula 2', 2);
insert into `areaPiano`value (default, 'aula 3', 2);
insert into `areaPiano`value (default, 'aula 4', 2);
insert into `areaPiano`value (default, 'aula 5', 2);
insert into `areaPiano`value (default, 'aula 6', 2);
insert into `areaPiano`value (default, 'corridoio 1', 2);
insert into `areaPiano`value (default, 'corridoio 2', 2);
insert into `sensore` value (default, 't1', 0, 1,current_timestamp(), current_timestamp(),default,1);
insert into `sensore` value (default, 't2', 0, 1,current_timestamp(), current_timestamp(),1,default);
insert into `sensore` value (default, 't3', 0, 1,current_timestamp(), current_timestamp(),default,1);
insert into `sensore` value (default, 't4', 0, 1,current_timestamp(), current_timestamp(),default,5);
insert into `sensore` value (default, 'u1', 0, 1,current_timestamp(), current_timestamp(),default,1);
insert into `sensore` value (default, 'u2', 0, 1,current_timestamp(), current_timestamp(),2,default);
insert into `sensore` value (default, 'u3', 0, 1,current_timestamp(), current_timestamp(),default,1);
insert into `sensore` value (default, 'l1', 0, 1,current_timestamp(), current_timestamp(),default,3);
insert into `sensore` value (default, 'l2', 0, 1,current_timestamp(), current_timestamp(),default,8);


select * from sensore;
delimiter //
//
create procedure `nuovoValore`(_idSensore int, x double)
begin
declare t time;
select s.oraUltimoInvio from sensore s where _idSensore=s.ID into t;
update sensore s set s.valore = x, s.oraUltimoInvio=current_timestamp(), s.oraInvioPrecedente=t  where s.ID=_idSensore;
end//



