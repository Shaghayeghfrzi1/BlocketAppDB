select * from Category
Insert into category (CategoryType) values ('Möbler')
Insert into category (CategoryType) values ('Mobiltelefoner')
Insert into category (CategoryType) values ('Cyklar')
Insert into category (CategoryType) values ('Datorer')

select * from Login
insert into Login (Username,Password) values ('Stina Firoozi','1234')
insert into Login (Username,Password) values ('Anna Petterson','0000')
insert into Login (Username,Password) values ('Kalle Svensson','4444')
delete from Login where Username='Kalle Bohl' and Password='0000'

select * from Advert
insert into Advert (Title,Description,Date,Price,CategoryID,LoginID) values ('Damcykel','28 tums Vega, nytt bakdäck','2020-07-04 00:00:00.000',500,3,2)
insert into Advert (Title,Description,Date,Price,CategoryID,LoginID) values ('Barncykel','Helt ny cykel och använd fåtal gånger.','2020-07-05 00:00:00.000',200,3,2)
insert into Advert (Title,Description,Date,Price,CategoryID,LoginID) values ('Damcykel','Cykel med handbroms och 7 växlar.','2020-03-14 00:00:00.000',800,3,1)
insert into Advert (Title,Description,Date,Price,CategoryID,LoginID) values ('Utemöbler','Bordet är 160cm. Dynorna ingår.','2018-09-20 00:00:00.000',750,1,2)
insert into Advert (Title,Description,Date,Price,CategoryID,LoginID) values ('Soffa','Bekväm och välskött soffa från MIO. Ny pris 12 000 kr','2014-11-28 00:00:00.000',6900,1,1)
insert into Advert (Title,Description,Date,Price,CategoryID,LoginID) values ('Iphone XS','Ölost, med laddare och usb kabel','2020-10-10 00:00:00.000',5000,2,3)
insert into Advert (Title,Description,Date,Price,CategoryID,LoginID) values ('Macbook pro','128 gb minne. batteritid 10h','2020-04-18 00:00:00.000',7400,4,3)
insert into Advert (Title,Description,Date,Price,CategoryID,LoginID) values ('Macbook air','258 gb minne och ny','2020-09-18 00:00:00.000',4900,4,1)



update advert set Title='Macbook air', Description='258 gb minne och ny', Date='2020-09-18 00:00:00.000', Price=4900 where AdvertID='8'



--****************************************************************************************************************************************
update advert set Price=690 where Title='Soffa'

select title from Advert where Title LIKE '%cyk%' or CategoryID=3
select * from Advert where CategoryID=1 order by Date desc
select * from Advert where  CategoryID=1 order by Price 

select Username,Username+','+Password as registerUser from Login

select a.title, a.description , a.Date , a.Price , c.categorytype+ l.username as Info
from Advert a
inner join Login l on a.LoginID=l.LoginID
inner join category c on a.categoryID=c.categoryid
where a.Title= 'damcykel' 

select *
from Advert a
inner join Login l on a.LoginID=l.LoginID
inner join category c on a.categoryID=c.categoryid
where a.Title= 'damcykel'

insert into Login(Username,Password) values ('aa','123')

select Title from Advert a
inner join login l on a.LoginID=l.LoginID
where l.Username+','+Password='Stina Firoozi,1234'
update advert set Title='Ny damcyckel' where Description='28 tums Vega, nytt bakdäck'

--insert into Advert (Title,CategoryID,Description,Date, Price, LoginID) values ()

--delete from Advert where title='Macbook air' 
update advert set Title='Macbook air', Description='XXXXXXX', Date='2020-09-18 00:00:00.000', Price='4789' where Title='Macbook air'

select Title, Description,date,Price from Advert where AdvertID=17

select AdvertID from Advert where Title='Macbook air'

update advert set  Price='7890' where Title='Macbook air'