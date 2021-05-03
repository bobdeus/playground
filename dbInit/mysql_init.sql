use mysql;
CREATE DATABASE mydb;

use mydb;
CREATE TABLE some_data(
   id INT NOT NULL AUTO_INCREMENT,
   title VARCHAR(100) NOT NULL,
   author VARCHAR(40) NOT NULL,
   created_date DATE,
   updated_date DATE,
   datas VARCHAR(21000) CHARACTER SET utf8,
   PRIMARY KEY ( id )
);

insert into datas(title,author,created_date,updated_date,datas) 
values('The title 1','Bob Hope','2021-05-17','2021-05-17','This is the datas in the thinger.');
insert into datas(title,author,created_date,updated_date,datas) 
values('The title 2','Fred Flintston','2021-05-17','2021-05-17','This is the datas in the thinger.');
insert into datas(title,author,created_date,updated_date,datas) 
values('The title 3','John Hopkins','2021-05-17','2021-05-17','This is the datas in the thinger.');
insert into datas(title,author,created_date,updated_date,datas) 
values('The title 4','Alex Bell','2021-05-17','2021-05-17','This is the datas in the thinger.');
insert into datas(title,author,created_date,updated_date,datas) 
values('The title 5','George Washington','2021-05-17','2021-05-17','This is the datas in the thinger.');
insert into datas(title,author,created_date,updated_date,datas) 
values('The title 6','James Franco','2021-05-17','2021-05-17','This is the datas in the thinger.');