CREATE SCHEMA Sasn;

CREATE TABLE Sasn.Nutriologo(
    IDNutriologo serial,
    NombreNutriologo varchar(50) NOT NULL,
    Sexo char,
    Telefono varchar (15) NOT NULL,
    Correo varchar (30) NOT NULL,
    Contracena varchar(16) NOT NUll,
    primary key(IDNutriologo)
);

CREATE TABLE Sasn.Paciente(
	IDPaciente serial,
	IDNutriologo int,
	NombrePaciente varchar(50) NOT NULL,
	FechaNacimiento Date,
	Sexo char,
	Telefono varchar(15) NOT NULL,
	primary key(IDPaciente)
);

ALTER TABLE Sasn.Paciente
ADD CONSTRAINT IDNutriologo
FOREIGN KEY(IDNutriologo)
REFERENCES Sasn.Nutriologo(IDNutriologo)
on delete cascade
on update cascade;


Create table Sasn.grupo_alimentos(
	id int PRIMARY KEY NOT NULL,
	nombre varchar(30)
);

INSERT INTO Sasn.grupo_alimentos (id,nombre) VALUES(1,'Verduras');
INSERT INTO Sasn.grupo_alimentos (id,nombre) VALUES(2,'Frutas');
INSERT INTO Sasn.grupo_alimentos (id,nombre) VALUES(3,'Cereales y Tuberculos');
INSERT INTO Sasn.grupo_alimentos (id,nombre) VALUES(4,'Leguminosas');
INSERT INTO Sasn.grupo_alimentos (id,nombre) VALUES(5,'Alimentos de origen animal');
INSERT INTO Sasn.grupo_alimentos (id,nombre) VALUES(6,'Lacteos');
INSERT INTO Sasn.grupo_alimentos (id,nombre) VALUES(7,'Aceites');

CREATE TABLE Sasn.Alimento (
	id int PRIMARY KEY NOT NULL,
	nombre varchar(50) NOT NULL,
	racion int NOT NULL,
	calorias int NOT NULL,
	Grupo_alimenticio int NOT NULL,
	CONSTRAINT fk_alimentos FOREIGN KEY (Grupo_alimenticio) REFERENCES sasn.grupo_alimentos(id)
);

INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('1','Acelga','100',19,'1');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('2','Achicoria','100',72,'1');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('3','Ajo','100',149,'1');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('4','Alcachofa','100',47,'1');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('5','Altramuces / Lupines','100',120,'1');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('6','Apio','100',16,'1');

INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('7','Aceitunas / Olivas','100',115,'2');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('8','Aguacate','100',160,'2');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('9','Arandanos','100',57,'2');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('10','Cerezas','100',50,'2');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('11','Ciruela','100',46,'2');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('12','Frambuesa','100',52,'2');

INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('13','Almidon de trigo','100',351,'3');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('14','Amaranto','100',371,'3');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('15','Arroz integral','100',388,'3');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('16','Avena integral','100',375,'3');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('17','Cracker / Galleta','100',502,'3');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('18','Nachos','100',499,'3');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('19','Palitos de pan / Piquitos / Grisines','100',408,'3');

INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('20','Frijoles con chile','100',97,'4');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('21','Lentejas','100',353,'4');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('22','Queso de soja / soya','100',235,'4');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('23','Tofu','100',76,'4');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('24','Yogur de soja / soya','100',66,'4');

INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('25','Atun','100',132,'5');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('26','Calamar','100',175,'5');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('27','Cangrejo de rio','100',82,'5');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('28','Langosta','100',89,'5');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('29','Pescado blanco','100',172,'5');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('30','Carne de cerdo','100',196,'5');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('31','Carne de pollo','100',172,'5');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('32','Carne picada / molida','100',400,'5');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('33','Chuletas de cordero','100',200,'5');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('34','Chuletas de pavo','100',114,'5');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('35','Higado de pollo','100',167,'5');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('36','Jamon','100',163,'5');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('37','Lomo de cerdo','100',204,'5');

INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('38','Arroz con leche','100',118,'6');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('39','Chocolate caliente','100',89,'6');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('40','Crema chantilli','100',266,'6');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('41','Crema para cafe','100',195,'6');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('42','Leche','100',61,'6');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('43','Leche condensada','100',321,'6');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('44','Leche de almendra','100',17,'6');

INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('45','Aceite de maiz','100',800,'7');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('46','Aceite de oliva','100',884,'7');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('47','Manteca de cerdo','100',902,'7');
INSERT INTO Sasn.Alimento (id,nombre,racion,calorias,Grupo_alimenticio) VALUES ('48','Mantequilla / Manteca','100',720,'7');

CREATE TABLE Sasn.Cita(
	IDCita serial,
	IDPaciente int NOT NULL,
	Fecha Date NOT NULL,
	Hora Time NOT NULL,
	Peso decimal(5,2),
	Altura decimal(3,2),
	IMC decimal(4,2),
	MedidaAbdomen decimal(3,2),
	MedidaBrazo decimal(3,2),
	MedidaPecho decimal(3,2),
	MedidaPierna decimal(3,2),
	Anotaciones text,
	primary key(IDCita)
);

ALTER TABLE Sasn.Cita
ADD CONSTRAINT IDPaciente
FOREIGN KEY(IDPaciente)
REFERENCES Sasn.Paciente(IDPaciente)
on delete cascade
on update cascade;

CREATE TABLE Sasn.Dietas (
    id serial,
    IDCita int,-- En cada cita se genera una nueva dieta
    ComidaSelec text,-- Guardar lo id's de las comidas seleccionadas por el usuario
    CategoriaComida SMALLINT,-- La categoria se refiere a si es comida,desayuno, etc.
    DiaSemana SMALLINT,-- El dia de la semana se referencia con un numero por ejemplo lunes seria igual a 1
    CONSTRAINT fk_dietas FOREIGN KEY (IDCita) REFERENCES Sasn.Cita(IDCita) 
    on delete cascade
    on update cascade,
    primary key(id)
);


CREATE TABLE Sasn.Rutina(
	IDRutina serial,
	IDCita smallint,
	Nombre varchar(50),
	Descripcion text,
	Duracion smallint,
	DiasSemana smallint,
	primary key(IDRutina)
);

ALTER TABLE Sasn.Rutina
ADD CONSTRAINT IDCita
FOREIGN KEY(IDCita)
REFERENCES Sasn.Cita(IDCita)
on delete cascade
on update cascade;

CREATE TABLE sasn.MenusGenericos (
    id serial,
    Nombre varchar(50),
    primary key(id)
);

CREATE TABLE Sasn.DatosMenuGenerico (
    id serial,
    Nombre int, --id del menu en la otra tabla
    ComidaSelec text,-- Guardar lo id's de las comidas seleccionadas por el usuario
    CategoriaComida SMALLINT,-- La categoria se refiere a si es comida,desayuno, etc.
    DiaSemana SMALLINT,-- El dia de la semana se referencia con un numero por ejemplo lunes seria igual a 1
    caloriasTotalesDia int,
    primary key(id),
    CONSTRAINT fk_MenuGenerico FOREIGN KEY (Nombre) REFERENCES Sasn.MenusGenericos(id) 
    on delete cascade
    on update cascade

);



CREATE TABLE Sasn.RutinaGenerica(
	IDRutina serial,
	Nombre varchar(50),
	Descripcion text,
	Duracion smallint,
	DiasSemana smallint,
	primary key(IDRutina)
);




