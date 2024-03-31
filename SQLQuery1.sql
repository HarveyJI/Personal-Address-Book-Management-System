create database AddressBook
on
primary
(	name= AddressBook,
	filename='D:\��ҵ\������ѧ��\.net c#\����ͨѶ¼����ϵͳ\AddressBook.mdf',
	size=8 mb,
	maxsize=10 mb
)
log on
(	name =AddressBook_log,
	filename='D:\��ҵ\������ѧ��\.net c#\����ͨѶ¼����ϵͳ\AddressBook.ldf',
	size=8 mb,
	maxsize=10 mb
)


create table LoginUser(
	account varchar(16) primary key,
	password varchar(18)
)

create table AddressInfo(
	name varchar(8),
	company varchar(40) ,
	linePhone varchar(13),
	mobilePhone char(11) primary key,
	classification varchar(8),
	email varchar(30),
	qq varchar(20)
	
)

insert into AddressInfo
values('վ','�����»�ѧԺ','0553123456','13637536449','����','123456@13','172164890')

insert into LoginUser
values('admin','123456')

select *from LoginUser

select *from AddressInfo

insert into AddressInfo
values
('�ͻ�ΰ','�����»�ѧԺ','055356789112','12345678911','ͬѧ','123456789@qq.com','1888888888'),
('����','�Ϸ��й�����','023145776879','1243567987','����','243671883@qq.com','267848826'),
('����','�����»�ѧԺ','025438724569','18844556677','ͬѧ','244837163@qq.com','2655647826'),
('����','�Ϸ�ѧԺ','023555231879','1225648987','����','224673883@qq.com','2245318826')
,('����','������·221��','023444666879','2457346987','����','2424318883@qq.com','1345278826')
,('����','�Ϸ�������','024531856879','1775597987','����','243642883@qq.com','2664388826')
