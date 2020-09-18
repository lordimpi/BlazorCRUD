// Run this script in your favorite SGBD
// For this example use SQLSERVER

Modify appsettings.json

"ConnectionStrings": {
    "SqlConnection": "your string connection"
    }

CREATE DATABASE DBBlazor

USE DBBlazor

CREATE TABLE Films
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	Title NVARCHAR(250) NOT NULL,
	Director NVARCHAR(150),
	ReleaseDate DATETIME,
);
