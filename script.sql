USE [master]
GO
/****** Object:  Database [gorails]    Script Date: 12/26/2017 1:14:24 AM ******/
CREATE DATABASE [gorails] ON  PRIMARY 
( NAME = N'gorails', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\gorails.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gorails_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\gorails_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [gorails] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [gorails].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [gorails] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [gorails] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [gorails] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [gorails] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [gorails] SET ARITHABORT OFF 
GO
ALTER DATABASE [gorails] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [gorails] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [gorails] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [gorails] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [gorails] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [gorails] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [gorails] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [gorails] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [gorails] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [gorails] SET  DISABLE_BROKER 
GO
ALTER DATABASE [gorails] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [gorails] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [gorails] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [gorails] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [gorails] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [gorails] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [gorails] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [gorails] SET RECOVERY FULL 
GO
ALTER DATABASE [gorails] SET  MULTI_USER 
GO
ALTER DATABASE [gorails] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [gorails] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'gorails', N'ON'
GO
USE [gorails]
GO
/****** Object:  Table [dbo].[passenger]    Script Date: 12/26/2017 1:14:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[passenger](
	[pass_id] [int] NOT NULL,
	[pass_name] [varchar](50) NOT NULL,
	[pass_age] [int] NOT NULL,
	[pass_street] [varchar](50) NOT NULL,
	[pass_password] [varchar](50) NOT NULL,
	[pass_phone] [int] NOT NULL,
	[pass_city] [varchar](50) NOT NULL,
 CONSTRAINT [PK_passenger] PRIMARY KEY CLUSTERED 
(
	[pass_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ticket]    Script Date: 12/26/2017 1:14:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ticket](
	[tickte_id] [int] IDENTITY(1,1) NOT NULL,
	[date_booked] [datetime] NOT NULL,
	[status] [varchar](50) NOT NULL,
	[pass_id] [int] NULL,
	[train_id] [int] NULL,
	[class] [varchar](50) NULL,
 CONSTRAINT [PK_ticket] PRIMARY KEY CLUSTERED 
(
	[tickte_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[train]    Script Date: 12/26/2017 1:14:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[train](
	[train_id] [int] IDENTITY(1,1) NOT NULL,
	[avilable_seats] [int] NOT NULL,
	[first_class] [int] NOT NULL,
	[business_class] [int] NOT NULL,
	[economy_class] [int] NOT NULL,
	[department_date] [datetime] NOT NULL,
	[department_location] [varchar](50) NOT NULL,
	[arrival_date] [datetime] NOT NULL,
	[destination] [varchar](50) NOT NULL,
	[duration] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[total_seats] [int] NOT NULL,
 CONSTRAINT [PK_train] PRIMARY KEY CLUSTERED 
(
	[train_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ticket]  WITH CHECK ADD  CONSTRAINT [belong] FOREIGN KEY([train_id])
REFERENCES [dbo].[train] ([train_id])
GO
ALTER TABLE [dbo].[ticket] CHECK CONSTRAINT [belong]
GO
ALTER TABLE [dbo].[ticket]  WITH CHECK ADD  CONSTRAINT [book] FOREIGN KEY([pass_id])
REFERENCES [dbo].[passenger] ([pass_id])
GO
ALTER TABLE [dbo].[ticket] CHECK CONSTRAINT [book]
GO
/****** Object:  StoredProcedure [dbo].[add_train]    Script Date: 12/26/2017 1:14:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[add_train]
@department_date datetime,
@department_location varchar(50),
@arrival_date datetime,
@destination varchar(50),
@price money,
@total_seats int

AS
BEGIN
	declare @fc int,@bc int,@ec int,@duration int;
	set @fc=(@total_seats*20/100);
	set @bc=((@total_seats)*30/100);
	set @ec=((@total_seats-@fc-@bc));
	set @duration =(SELECT DATEDIFF(hh, @department_date, @arrival_date) as int);
	insert into train (avilable_seats,first_class,business_class,economy_class,department_date,department_location,arrival_date,destination,duration,Price,total_seats)
				 values (@total_seats,@fc,@bc,@ec,@department_date,@department_location,@arrival_date,@destination,@duration,@price,@total_seats);

END
GO
/****** Object:  StoredProcedure [dbo].[book_ticket]    Script Date: 12/26/2017 1:14:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[book_ticket]
	@train_id int,
	@class varchar(50),
	@pass_id int,
	@date datetime,
	@avilable int output,
	@departime datetime output,
	@departlocation varchar(50) output,
	@train_arrival_time datetime output,
	@train_arrivale_location varchar(50) output,
	@duration int output,
	@ticket_id int output,
	@price Money output
	
AS
BEGIN
	declare @x int,@a int,@s int;
	-- s number of avilable seats in the class
	-- a is the numbet of total seats
	-- x is the numbe  of total seats in the selected class
	declare @fc int,@bc int,@ec int;
	set @a=(select train.total_seats from train where train_id=@train_id);
	set @avilable=0;
	set @fc=(@a*20/100);
	set @bc=((@a)*30/100);
	set @ec=((@a-@fc-@bc));
	set @price=(select train.Price from train where train_id=@train_id)
	----------------------------------------------------------------------------------------------------
	if @class='First Class'
	begin
	set @s=(select train.first_class from train where train_id=@train_id);
	set @x=@fc;
	set @price*=2
	end
	else if @class='Buisness Class'
	begin
	set @x=@bc;
	set @s=(select train.business_class from train where train_id=@train_id);
	set @price*=1.5
	
	end
	else if @class='Economic Class'
	begin
	set @x=@ec;
	set @s=(select train.economy_class from train where train_id=@train_id);
	
	end

	---------------------------------------------------------------------------------------------------------------------------
	if ( @s<=0 and (select count(ticket.status) from ticket where ticket.train_id=@train_id and ticket.status='waiting'and ticket.class=@class)<(@x/10) and (@x/10)>0 )
	begin
	set @avilable=2;
	insert into ticket values(@date,'waiting',@pass_id,@train_id,@class);
	end
	
	-----------------------------------------------------------------------------------------------
	if ( @s >0 )
	begin
		set @avilable=1;
		insert into ticket values(@date,'reserved',@pass_id,@train_id,@class)
		update train set avilable_seats=avilable_seats-1 where train_id=@train_id;
		------------------------
		if @class='First Class'
		begin

			update train set first_class=first_class-1 where train_id=@train_id;

		end
		------------------------
		if @class='Buisness Class'
		begin
			update train set business_class=business_class-1 where train_id=@train_id;

		end
		------------------------
		if @class='Economic Class'
		begin
			update train set economy_class=economy_class-1 where train_id=@train_id;

		end
	end
	
	---------------------------------------------------------------------------------------------------------------------------
	if(@avilable=1 or @avilable=2)
	begin
		set @departime =(select train.department_date from train where train_id=@train_id)
		set @departlocation =(select train.department_location from train where train_id=@train_id)
		set @train_arrival_time =(select train.arrival_date from train where train_id=@train_id)
		set @train_arrivale_location =(select train.destination from train where train_id=@train_id)
		set @duration =(select train.duration from train where train_id=@train_id)
		set @ticket_id =(SELECT TOP 1 ticket.tickte_id FROM ticket where ticket.train_id=@train_id ORDER BY tickte_id DESC)
		
	end

END
GO
/****** Object:  StoredProcedure [dbo].[change_status]    Script Date: 12/26/2017 1:14:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[change_status]
@train_id int,
@class varchar(50),
@avilable int output

as
begin
set @avilable=0;
declare @ticket_id int = (select top 1 ticket.tickte_id from ticket where ticket.status='waiting' and ticket.train_id=@train_id)
	if exists (select top 1 ticket.tickte_id from ticket where ticket.status='waiting' and ticket.train_id=@train_id)
	begin 
		update ticket set ticket.status='reserved' where ticket.tickte_id=@ticket_id and ticket.train_id=@train_id
		set @avilable=1;
	end
	else 
	begin
		set @avilable=1;
		update train set avilable_seats=avilable_seats+1 where train_id=@train_id;
		if @class='First Class'
			begin

				update train set first_class=first_class+1 where train_id=@train_id;

			end
			else if @class='Buisness Class'
			begin
				update train set business_class=business_class+1 where train_id=@train_id;

			end
			else if @class='Economic Class'
			begin
				update train set economy_class=economy_class+1 where train_id=@train_id;
			end	
	
	
	end
	
end
GO
/****** Object:  StoredProcedure [dbo].[check_pass_id]    Script Date: 12/26/2017 1:14:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[check_pass_id]
	@pass_id int,
	@pass_name varchar(50),
	@pass_age int,
	@pass_street varchar(50),
	@pass_password varchar(50),
	@pass_phone int,
	@pass_city varchar(50),
	@b int output
AS
BEGIN
	IF NOT Exists (select 1 From passenger where pass_id=@pass_id)
	begin
	set @b=1;
	insert into passenger values (@pass_id,@pass_name,@pass_age,@pass_street,@pass_password,@pass_phone,@pass_city)
	return @b
	end
	else
	begin
	set @b=0;
	return @b
	end
   
END
GO
/****** Object:  StoredProcedure [dbo].[check_train]    Script Date: 12/26/2017 1:14:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[check_train]
	@train_id int,
	@avilable int output
	
AS
BEGIN
	if exists (select 1 from train where train_id=@train_id)
	begin
	set @avilable=1
	end
	else
	begin
	set @avilable=0;
	end
	return @avilable;
END
GO
/****** Object:  StoredProcedure [dbo].[delete_ticket]    Script Date: 12/26/2017 1:14:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[delete_ticket]
	@ticket_d int,
	@avilable int output
	
AS
BEGIN
	--check if the ticket existes
	if exists (select 1 from ticket where @ticket_d=ticket.tickte_id)
	begin 
		if (select status from ticket where @ticket_d=ticket.tickte_id)='reserved'
		begin
			set @avilable=1;
			declare @class varchar(50)=(select ticket.class from ticket where tickte_id=@ticket_d);
			declare @train_d int =(select ticket.train_id from ticket  where tickte_id=@ticket_d);
			declare @ava int ;
			exec change_status @train_d,@class,@ava output;
			delete from ticket where tickte_id=@ticket_d;
		end  
	end  
	else
	begin
		set @avilable=0;

	end 
	
End
GO
/****** Object:  StoredProcedure [dbo].[delete_train]    Script Date: 12/26/2017 1:14:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[delete_train]
	@train_id int,
	@avilable int output
AS
BEGIN
	set @avilable=0;
	if EXISTS (select * from train where train.train_id=@train_id)
	begin 
		
		delete from ticket where ticket.train_id=@train_id
		delete from train where train.train_id=@train_id
		set @avilable=1;
	end
	

	
END
GO
/****** Object:  StoredProcedure [dbo].[details]    Script Date: 12/26/2017 1:14:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[details]
as
begin
select r.train_id,k.tickte_id,r.department_location,r.destination,r.department_date,r.arrival_date,r.duration,k.status 
from train r inner join ticket k 
on k.train_id=r.train_id
ORDER BY r.department_date
end
GO
/****** Object:  StoredProcedure [dbo].[get_trains]    Script Date: 12/26/2017 1:14:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[get_trains]
	
AS
BEGIN
	select * from train;
END
GO
/****** Object:  StoredProcedure [dbo].[passenger_login]    Script Date: 12/26/2017 1:14:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[passenger_login]
	@pass_id int,
	@pass_password varchar(50),
	@output int output
as
BEGIN
	IF Exists (select 1 from passenger where pass_id = @pass_id and pass_password=@pass_password)
	begin 
	set @output=1
	end
	else
	begin
	set @output=0
	end
	return @output
END
GO
USE [master]
GO
ALTER DATABASE [gorails] SET  READ_WRITE 
GO
