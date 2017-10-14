Create table tblEmployee
(
 Id int Primary Key Identity(1,1),
 Name nvarchar(50),
 Gender nvarchar(10),
 City nvarchar(50),
 DateOfBirth DateTime
)

Insert into tblEmployee values('Mark','Male','London','01/05/1979')
Insert into tblEmployee values('John','Male','Chennai','03/07/1981')
Insert into tblEmployee values('Mary','Female','New York','02/04/1978')
Insert into tblEmployee values('Mike','Male','Sydeny','02/03/1974')
Insert into tblEmployee values('Scott','Male','London','04/06/1972')


Create procedure spGetAllEmployees
as
Begin
 Select Id, Name, Gender, City, DateOfBirth
 from tblEmployee
End