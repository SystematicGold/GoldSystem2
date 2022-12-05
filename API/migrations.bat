@echo off
set name_m = Default
echo Plese enter Migration title
set /p name_m= 

dotnet ef migrations add %name_m% -o Data/Migrations
dotnet ef database update

pause