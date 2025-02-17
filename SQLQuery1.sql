CREATE DATABASE MyDatabase
USE MyDatabase

CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Password NVARCHAR(256) NOT NULL, 
    Email NVARCHAR(100) NOT NULL
)
/*Nếu password quá dài cột sẽ không chứa được, lúc đó nên đổi kiểu NVCHAR qua VARBINARY
Đổi kiếu string qua byte[] cho hashed password*/


