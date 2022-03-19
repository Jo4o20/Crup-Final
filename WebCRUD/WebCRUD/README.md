package necessário
Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools
Microsoft.EntityFrameworkCore.Design

todo o código foi feito pelo visual studio 2022
backend feito em c# com sqlserver
não consegui conectar com o servidor do banco de dados no compuatador
e tambem não consegui implemenatar nesse com angular,
e com isso n consegui fazer a anasile so vencimento por não conseguir ligar com o banco

não sei como iniciar o codigo em outros computadores

#Add-Migration Initial-criacao -Context Contexto
ou
#dotnet ef migrations add InitialCreate -Context Contexto
em seguida, pra criar a database (deveria ser feito, mas é aqui o problema)
#Update-Database -Context Contexto
ou
#dotnet ef database update -Context Contexto

