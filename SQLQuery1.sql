CREATE DATABASE data1;

CREATE TABLE bag (

    Person_ID int IDENTITY(1,1),
    Customer_Name nvarchar(255),
    Cell nvarchar(255),
    Work_Type nvarchar(255),
    Charges int
);

SELECT * FROM bag;

SELECT *FROM bag where Cell='123'

INSERT INTO bag
VALUES ( 'Abdullah', '03207677525','reparing',45);
