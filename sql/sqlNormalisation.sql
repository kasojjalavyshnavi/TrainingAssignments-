create database Normalization

use Normalization



create table NormalForm

(ClientNo varchar(10) not null, Cname varchar(100),PropertyNo varchar(20),Paddress varchar(100),rentstart varchar(10),

rentfinish varchar(10), rent float, ownerno varchar(20),OName varchar(100))





insert into NormalForm values

('CR76','Jhon Kay','PG4','6 Lawrence st,Glasgow ','1-Jul-00' ,'31-Aug-01',350,'CO40','Tina Murphy'),

('CR76','Jhon Kay','PG4','5 Novar Dr,Glassgow','1-Sep-02' ,'1-Sep-02',450,'CO93','Tony Shaw'),

('CR56','Aline Stewan','PG4','6 Lawrence st,Glasgow','1-Sep-99' ,'10-Jun-00',350,'CO40','Tina Murphy'),

('CR56','Aline Stewan','PG36','2 Manor Rd,Glasgow','10-Oct-00' ,'1-Dec-01',370,'CO93','Tony Shaw'),

('CR56','Aline Stewan','PG16','5 Novar Dr,Glassgow','1-Nov-02' ,'1-Aug-03',450,'CO93','Tony Shaw')



select*from NormalForm