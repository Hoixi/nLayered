# SQL Bağlantısı
DataAccess > DataAccessServiceRegistration.cs

![image](https://github.com/Hoixi/nLayered/assets/24763981/744f0e2a-1960-45c5-9f3b-88631edcb939)

services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DBName;Trusted_Connection=true"));

![image](https://github.com/Hoixi/nLayered/assets/24763981/45ba1f1c-db5c-47ea-aade-113481a72866)
