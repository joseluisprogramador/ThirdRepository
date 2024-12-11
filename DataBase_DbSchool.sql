
Create DataBase Db_School

Go

Use Db_School

Go

Create Table T_Students(
c_Id int Identity(1,1),
c_StudentNames Varchar(60),
c_StudentLastNames Varchar(60),
c_Age int,
c_Course Varchar(5),
c_Teacher Varchar(60),
c_Fecha DateTime Default GetDate() 
);
Go



Create Procedure Pro_AddStudents
@c_StudentNames Varchar(40) ,
@c_StudentLastNames Varchar(40) ,
@c_Age int ,
@c_Course Varchar(4) ,
@c_Teacher Varchar(60) 
As
  Insert Into T_Students(c_StudentNames, c_StudentLastNames, c_Age, c_Course, c_Teacher)   
  Values(@c_StudentNames,@c_StudentLastNames,@c_Age,@c_Course,@c_Teacher)
Go


Create Procedure Pro_EditStudents
@c_StudentNames Varchar(40) ,
@c_StudentLastNames Varchar(40) ,
@c_Age int ,
@c_Course Varchar(4) ,
@c_Teacher Varchar(60), 
@c_Id int
As
Update T_Students Set 
c_StudentNames=@c_StudentNames ,
c_StudentLastNames=@c_StudentLastNames,
c_Age=@c_Age ,
c_Course=@c_Course ,
c_Teacher=@c_Teacher
Where c_Id=@c_Id
Go


Create Procedure Pro_DeleteStudents
@c_Id int
As
 Delete From T_Students Where c_Id=@c_Id
Go


Create Procedure Pro_SelectStudents
As
  Select *From T_Students
Go


Drop Table T_Students

Go

Insert Into T_Students(c_StudentNames, c_StudentLastNames, c_Age, c_Course, c_Teacher)  
Values
('Jose luis','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Maria Camila','Perez Bolaño',24,'10°A','Miguel Dario Cervantes Araujo'),
('Carmen Patricia','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Julia Maria','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Jesus David','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Josefa Elena','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Cristian Arturo','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Arturo Jose','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Luisa Fernanda','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Gloria de jesus','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Jorge luis','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Roberto Carlos','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Geovanny Omar','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Marlene Elena','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Luis Alfredo','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Juan Camilo','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Kiara Maria','Maldonado Muriel',24,'10°A','Miguel Dario Cervantes Araujo'),
('Edwin Guillermo','Tapia Cordoba',24,'10°A','Miguel Dario Cervantes Araujo'),
('Elkin Dario','Carrillo Almirante',24,'10°A','Miguel Dario Cervantes Araujo'),
('Francisco Alberto','Rua Miranda',24,'10°A','Miguel Dario Cervantes Araujo'),
('Armanda Miguel','Araujo Peña',24,'10°A','Miguel Dario Cervantes Araujo'),
('Edgar David','Charris Charris',24,'10°A','Miguel Dario Cervantes Araujo'),
('Ronald Andres','Villegas Peralta',24,'10°A','Miguel Dario Cervantes Araujo'),
('Nicol Maria','De La Torre Condado',24,'10°A','Miguel Dario Cervantes Araujo'),
('Johan De Jesus','Acendra Maldonado',24,'10°A','Miguel Dario Cervantes Araujo'),
('Marcela Margarita','Muriel Salcedo',24,'10°A','Miguel Dario Cervantes Araujo'),
('Danner Alexander', 'Echeverria Salcedo',24,'10°A','Miguel Dario Cervantes Araujo'),
('Rafael Jose','Silva Pacheco',24,'10°A','Miguel Dario Cervantes Araujo'),
('Paul Alberto','Casablanca Rodriguez',24,'10°A','Miguel Dario Cervantes Araujo'),
('German Jose','Pacheco Pacheco',24,'10°A','Miguel Dario Cervantes Araujo'),
('Antonel Dario','Alvarez Guerrero',24,'10°A','Miguel Dario Cervantes Araujo'),
('Shakira Maria','Cohen Maldonado',24,'10°A','Miguel Dario Cervantes Araujo'),
('Marco Alejandro','Maldonado Paez',24,'10°A','Miguel Dario Cervantes Araujo'),
('Gabriel Andres','Pereira De Paz',24,'10°A','Miguel Dario Cervantes Araujo'),
('Raul Antonio','Villa Esperanza',24,'10°A','Miguel Dario Cervantes Araujo'),
('Meribeth','Acendra Maldonado',24,'10°A','Miguel Dario Cervantes Araujo'),
('Pedro Jose','Zapata Hernandez',24,'10°A','Miguel Dario Cervantes Araujo'),
('Francisco Junio','Miranda Ortega',24,'10°A','Miguel Dario Cervantes Araujo'),
('Hector Habbit','Cohen Maldonado',24,'10°A','Miguel Dario Cervantes Araujo')
Go


Truncate Table T_Students

Go

