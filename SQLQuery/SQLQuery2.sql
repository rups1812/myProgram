create table hotel
(hotelid int,
hotelname varchar(20));

alter table hotel add city varchar(25);
alter table hotel add rating int;

select * from hotel;

alter table hotel drop column rating;

alter table hotel alter column rating float;

alter table hotel alter column hotelid int not null;
alter table hotel add Primary Key(hotelid);

sp_help hotel;