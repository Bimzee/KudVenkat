Create table tblDepartments
(
 Id int Primary Key Identity(1,1),
 Name nvarchar(50),
)


insert into tblDepartments(Name) values ('Payroll')

select * from tblDepartments

alter table tblDepartments add isSelected bit

update tblDepartments set isSelected=1 where id=1

CREATE TABLE tblCity
(
 ID INT IDENTITY PRIMARY KEY,
 Name NVARCHAR(100) NOT NULL,
 IsSelected BIT NOT NULL
)

Insert into tblCity values ('London', 0)
Insert into tblCity values ('New York', 0)
Insert into tblCity values ('Sydney', 1)
Insert into tblCity values ('Mumbai', 0)
Insert into tblCity values ('Cambridge', 0)