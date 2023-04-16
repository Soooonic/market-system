/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2017                    */
/* Created on:     5/30/2022 1:39:08 PM                         */
/*==============================================================*/


if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ORDERS') and o.name = 'FK_ORDERS_REFERENCE_PRODUCT')
alter table ORDERS
   drop constraint FK_ORDERS_REFERENCE_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('ORDERS') and o.name = 'FK_ORDERS_REFERENCE_USER_TAB')
alter table ORDERS
   drop constraint FK_ORDERS_REFERENCE_USER_TAB
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('PRODUCT') and o.name = 'FK_PRODUCT_PART_CATEGORI')
alter table PRODUCT
   drop constraint FK_PRODUCT_PART_CATEGORI
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STOCK') and o.name = 'FK_STOCK_STOCK_PRODUCT')
alter table STOCK
   drop constraint FK_STOCK_STOCK_PRODUCT
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STOCK') and o.name = 'FK_STOCK_STOCKED_STORE')
alter table STOCK
   drop constraint FK_STOCK_STOCKED_STORE
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('STORE') and o.name = 'FK_STORE_REFERENCE_USER_TAB')
alter table STORE
   drop constraint FK_STORE_REFERENCE_USER_TAB
go

if exists (select 1
            from  sysobjects
           where  id = object_id('CATEGORIES')
            and   type = 'U')
   drop table CATEGORIES
go

if exists (select 1
            from  sysobjects
           where  id = object_id('ORDERS')
            and   type = 'U')
   drop table ORDERS
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('PRODUCT')
            and   name  = 'PART_FK'
            and   indid > 0
            and   indid < 255)
   drop index PRODUCT.PART_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('PRODUCT')
            and   type = 'U')
   drop table PRODUCT
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('STOCK')
            and   name  = 'STOCKED_FK'
            and   indid > 0
            and   indid < 255)
   drop index STOCK.STOCKED_FK
go

if exists (select 1
            from  sysindexes
           where  id    = object_id('STOCK')
            and   name  = 'STOCK_FK'
            and   indid > 0
            and   indid < 255)
   drop index STOCK.STOCK_FK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STOCK')
            and   type = 'U')
   drop table STOCK
go

if exists (select 1
            from  sysobjects
           where  id = object_id('STORE')
            and   type = 'U')
   drop table STORE
go

if exists (select 1
            from  sysobjects
           where  id = object_id('USER_TABLE')
            and   type = 'U')
   drop table USER_TABLE
go

/*==============================================================*/
/* Table: CATEGORIES                                            */
/*==============================================================*/
create table CATEGORIES (
   CATID                int                  not null,
   CATNAME              varchar(20)          not null,
   constraint PK_CATEGORIES primary key (CATID)
)
go

/*==============================================================*/
/* Table: ORDERS                                                */
/*==============================================================*/
create table ORDERS (
   PRO_ID               int                  null,
   CUS_ID               int                  null
)
go

/*==============================================================*/
/* Table: PRODUCT                                               */
/*==============================================================*/
create table PRODUCT (
   PID                  int                  not null,
   CATID                int                  not null,
   PNAME                varchar(30)          null,
   PRICE                decimal              null,
   QUANTITY             int                  null,
   constraint PK_PRODUCT primary key (PID)
)
go

/*==============================================================*/
/* Index: PART_FK                                               */
/*==============================================================*/




create nonclustered index PART_FK on PRODUCT (CATID ASC)
go

/*==============================================================*/
/* Table: STOCK                                                 */
/*==============================================================*/
create table STOCK (
   STID                 int                  not null,
   STORE_ID             int                  not null,
   QUANTITY             int                  not null
)
go

/*==============================================================*/
/* Index: STOCK_FK                                              */
/*==============================================================*/




create nonclustered index STOCK_FK on STOCK (STID ASC)
go

/*==============================================================*/
/* Index: STOCKED_FK                                            */
/*==============================================================*/




create nonclustered index STOCKED_FK on STOCK (STORE_ID ASC)
go

/*==============================================================*/
/* Table: STORE                                                 */
/*==============================================================*/
create table STORE (
   SID                  int                  not null,
   USER_ID              int                  null,
   SNAME                varchar(30)          not null,
   constraint PK_STORE primary key (SID)
)
go

/*==============================================================*/
/* Table: USER_TABLE                                            */
/*==============================================================*/
create table USER_TABLE (
   EMAIL                varchar(100)         not null,
   ADDRESS              varchar(100)         null,
   PHONE                varchar(20)          not null,
   USER_ID              int                  not null,
   USERNAME             varchar(30)          not null,
   PASSWORD             varchar(50)          not null,
   STATUS               varchar(30)          not null,
   constraint PK_USER_TABLE primary key (USER_ID)
)
go

alter table ORDERS
   add constraint FK_ORDERS_REFERENCE_PRODUCT foreign key (CUS_ID)
      references PRODUCT (PID)
go

alter table ORDERS
   add constraint FK_ORDERS_REFERENCE_USER_TAB foreign key (PRO_ID)
      references USER_TABLE (USER_ID)
go

alter table PRODUCT
   add constraint FK_PRODUCT_PART_CATEGORI foreign key (CATID)
      references CATEGORIES (CATID)
go

alter table STOCK
   add constraint FK_STOCK_STOCK_PRODUCT foreign key (STID)
      references PRODUCT (PID)
go

alter table STOCK
   add constraint FK_STOCK_STOCKED_STORE foreign key (STORE_ID)
      references STORE (SID)
go

alter table STORE
   add constraint FK_STORE_REFERENCE_USER_TAB foreign key (USER_ID)
      references USER_TABLE (USER_ID)
go

