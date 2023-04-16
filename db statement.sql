create database supermarket;
use supermarket;
go

create table User_table(
	usId int primary key identity(1,1),
	username varchar(30) not null unique,
	email varchar(30) not null unique,
	password varchar(30) not null unique,
	phone varchar(20) ,
	address varchar(50) not null,
	status varchar(30) check (status in ('customer','admin'))
);
go 
DBCC CHECKIDENT ('User_table',RESEED,1);
go 
create table product(
	pid int primary key identity(1,1),
	pname varchar(30) not null,
	price decimal (8) not null,
);
alter table product
add quntity int ;


alter table product
add catId int foreign key references categories(catId);

go
create table orders(
	pro_id int ,
	cus_id int ,
	constraint pro_ord_fk foreign key (pro_id)
	references product(pid),
	constraint cus_ord_fk foreign key (cus_id)
	references User_table(usid),
);

go
drop table categories;

go 
create table categories(
	catId int primary key identity(1,1),
	catName varchar(30) not null,
)
go 
create table stock(
	stId int references product(pid),
	quantity int not null,
	store_id  int references stores(sId)
)

go
alter table stock 
drop column stId;

go 
create table stores(
	sId int primary key identity(1,1),
	sname varchar(30) not null,
)

-- showing availble products
go
select* from product where quntity is not null;
-- showing stock
 go
select stock.stId,product.pname,stock.quantity
from product join stock on product.pid = stock.stId
where quantity < 12;

-- max freq
 go 
 select  c.usId,c.username,c.email,c.password,c.phone,c.address ,count(o.cus_id)as 'max_customer'
 from user_table as c inner join orders as o  on c.usId=o.cus_id
 group by c.usid,c.username,c.email,c.password,c.phone,c.address
 order by 'max_customer' desc;

-- max bought product
go 
 select top 1 p.pid,p.pname,p.price,p.quntity ,count(o.cus_id) as 'max_product'
 from product as p inner join orders as o on p.pid = o.pro_id
 group by p.pid,p.pname,p.price,p.quntity
 order by 'max_product' desc;

 -- prodcuts not sell
 go
 select pid,pname,price,quntity 
 from product 
 where pid not in(select pro_id from orders); 

 -- customers not by
 go
 select usId,username, email,password,phone,address
 from User_table
 where usId not in(select cus_id from orders);

 -- max customers
 go 
 select top 1 c.usId,c.username,c.email,c.password,c.phone,c.address ,count(o.cus_id)as 'max_customer'
 from user_table as c inner join orders as o  on c.usId=o.cus_id
 group by c.usid,c.username,c.email,c.password,c.phone,c.address
 order by 'max_customer' desc;

 -- max categoreies
 go
 select top 1 categories.catId,categories.catName, count(product.catId) as 'number of products'
 from categories join product join orders on product.pid = orders.pro_id
 on product.catId = categories.catId
 group by categories.catId,categories.catName
 order by 'number of products' desc; 

 -- all informations about products and how many customers bought it
go 
 select p.pid,p.pname,p.price,p.quntity, count(DISTINCT o.cus_id) as 'numbre of customers'
 from product as p inner join orders as o  on p.pid =o.pro_id
 group by p.pid,p.pname,p.price,p.quntity; 




 









