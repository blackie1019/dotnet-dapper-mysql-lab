USE `dapper-test`;

CREATE TABLE Member
(
    Id int PRIMARY KEY AUTO_INCREMENT,
    Code NVARCHAR(20),
    Name NVARCHAR(50),
    DateCreated datetime,
    DateUpdated datetime
);
CREATE UNIQUE INDEX Member_Id_uindex ON Member (Id);
CREATE UNIQUE INDEX Member_Code_uindex ON Member (Code);