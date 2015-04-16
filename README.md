# CGroupAssignment

Some documentation for C# group project:
Database One: Books creating:
CREATE TABLE Books(
Name varchar(20),
ReleaseDate Date,
ISBN INT,
Id INT PRIMARY KEY);

Adding an entry for testing 
INSERT INTO Books VALUES('A Game of Thrones', '19960706', '0553103547', '0');

Review database created
CREATE TABLE Reviews(
Reviewer varchar(20),
Review varchar(MAX),
Id int primary key,
Date date,
Rating int,
BookId int FOREIGN KEY REFERENCES Books(Id));

Adding an entry for testing:
INSERT INTO Reviews VALUES(
'Gordon Cox',
'This is the best book ever created, anyone who doesnt think so is a big dummy',
0,
'20150416',
10,
0);
