create database AddressBook
on
primary
(	name= AddressBook,
	filename='D:\作业\大三上学期\.net c#\个人通讯录管理系统\AddressBook.mdf',
	size=8 mb,
	maxsize=10 mb
)
log on
(	name =AddressBook_log,
	filename='D:\作业\大三上学期\.net c#\个人通讯录管理系统\AddressBook.ldf',
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
values('站','安徽新华学院','0553123456','13637536449','本人','123456@13','172164890')

insert into LoginUser
values('admin','123456')

select *from LoginUser

select *from AddressInfo

insert into AddressInfo
values
('纪华伟','安徽新华学院','055356789112','12345678911','同学','123456789@qq.com','1888888888'),
('张三','合肥市公安局','023145776879','1243567987','家人','243671883@qq.com','267848826'),
('李四','安徽新华学院','025438724569','18844556677','同学','244837163@qq.com','2655647826'),
('王五','合肥学院','023555231879','1225648987','朋友','224673883@qq.com','2245318826')
,('刘六','望江西路221号','023444666879','2457346987','朋友','2424318883@qq.com','1345278826')
,('赵云','合肥市政府','024531856879','1775597987','家人','243642883@qq.com','2664388826')
