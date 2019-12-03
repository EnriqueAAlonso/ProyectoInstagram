create database fakeInstagram2
go
use fakeInstagram2
go

create table users(
username nvarchar(100) not null,
email nvarchar(100) not null,
pwd nvarchar(100),
pPath nvarchar(MAX),
descript nvarchar(MAX));
go


create table followers(

follower nvarchar(100) not null,
followed nvarchar(100));
go
create procedure addUser
(
	@username nvarchar(100),
	@email nvarchar(100),
	@pwd nvarchar(100),
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	insert into users
	values
	(@username,@email,@pwd,NULL,NULL)
end try
begin catch
	set @haserror = 1;
end catch
go
create procedure getuser
(
@user nvarchar(100)
)
as
select * from users where @user=username
go
create procedure follow
(
	@follower nvarchar(100),
	@followee nvarchar(100),
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	insert into followers
	values
	(@follower,@followee)
end try
begin catch
	set @haserror = 1;
end catch
go
create procedure getFollowers
(
@user nvarchar(100)
)
as
select * from followers where @user=follower
go
create procedure getFollowing
(
@user nvarchar(100)
)
as
select * from followers where @user=followed
go
create procedure logUser
(
	@username nvarchar(100),
	@pwd nvarchar(100),
	@haserror bit out
)
as
begin try

	select * from users where @username = username and @pwd =pwd
	set @haserror = 0;
end try
begin catch
	set @haserror = 1;
end catch
GO

create procedure unFollow
(
@user nvarchar(100),
@followed nvarchar(100)
)
as
delete from followers where @user=follower and @followed=followed
go
Create Table Posts(
PostID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
publication NVARCHAR(MAX)  NOT NULL,
username nvarchar(MAX) Not NULL,
dPublication DateTime Not Null,
descript nvarchar(MAX)
)
go
create TABLE Publications
(
	ID nvarchar(MAX),
	profile nvarchar(MAX),
	imgPath nvarchar(MAX),
	date datetime,
	description nvarchar(MAX)
)
go
create procedure createPublication
(
	@ID nvarchar(MAX),
	@profile nvarchar(MAX),
	@date datetime,
	@imgPath nvarchar(MAX),
	@description nvarchar(MAX),
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	insert into Publications
	values
	(@ID,@profile,@imgPath,@date,@description)
end try
begin catch
	set @haserror = 1;
end catch
go
create procedure getPublication
(
	
	@profile nvarchar(MAX),
	@haserror bit out
)
as

select * from publications where @profile=profile order by date desc



go
create procedure updatePicture
(
	
	@profile nvarchar(MAX),
	@pPath nvarchar(MAX)
)
as

UPDATE users set pPath=@pPath where username=@profile
go

create procedure updateDesc
(
	
	@profile nvarchar(MAX),
	@desc nvarchar(MAX)
)
as

UPDATE users set descript=@desc where username=@profile
go
create TABLE Story
(
	ID nvarchar(MAX),
	profile nvarchar(MAX),
	imgPath nvarchar(MAX),
	date datetime
)
go
create procedure createStory
(
	@ID nvarchar(MAX),
	@profile nvarchar(MAX),
	@date datetime,
	@imgPath nvarchar(MAX),
	
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	insert into Story
	values
	(@ID,@profile,@imgPath,@date)
end try
begin catch
	set @haserror = 1;
end catch
go
create procedure DeleteStory
(
	
	@date datetime
	
	
)
as
DELETE FROM Story WHERE DATEDIFF(hour, date, @date)>24

go
create procedure getStories
(
	
	@profile nvarchar(MAX)
	
)
as

select * from Story where @profile=profile order by date desc

go

create procedure getPub
(
	
	@id nvarchar(MAX)
	
)
as

select * from publications where @id=ID order by date desc
go
create TABLE likes
(
	ID nvarchar(MAX),
	username nvarchar(MAX),
	date datetime
)
go
create procedure getLike
(
	
	@id nvarchar(MAX),
	@username nvarchar(max)
	
)
as
select * from likes where @id=ID and @username=username order by date desc
go
create procedure deleteLike
(
	
	@id nvarchar(MAX),
	@username nvarchar(max)
	
)
as
delete from likes where @id=ID and @username=username 
go
create procedure createLike
(
	@ID nvarchar(MAX),
	@profile nvarchar(MAX),
	@date datetime,
	
	@haserror bit out
)
as
begin try
	set @haserror = 0;
	insert into likes
	values
	(@ID,@profile,@date)
end try
begin catch
	set @haserror = 1;
end catch
go
create procedure getAllTheLikes
(
	
	@id nvarchar(MAX)
	
)
as
 Select * from likes where @id=ID  order by date desc
go