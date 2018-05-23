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