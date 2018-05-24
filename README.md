# Docker image
If you are running this project on a Mac or Linux, you'll need the SQL Server docker image. 
Download it from [here](https://docs.microsoft.com/pt-br/sql/linux/quickstart-install-connect-docker?view=sql-server-linux-2017) (vesion `mssql-server-linux:2017-CU6`): 


# Database
```SQL
CREATE LOGIN usertest WITH PASSWORD = 'user@test123'
GO
CREATE USER usertest FROM LOGIN usertest
GO
ALTER LOGIN usertest WITH DEFAULT_DATABASE = TestDB
GO
EXEC sp_addrolemember 'db_owner', 'usertest'
GO
```

# Run migrations
```bash
#!/bin/bash

dotnet ef database update
```