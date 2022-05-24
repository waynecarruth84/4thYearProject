 Create proc Sp_login
 @FullName varchar(50),
 @Password varchar(50),
 @Email varchar(50),
 @Isvalid bit out
 as
 begin
 set @Isvalid = (select COUNT(1) from dbo.Users where FullName = @FullName AND Password = @Password AND Email = @Email)
 end

 Select * from dbo.Users;