ALTER ROLE [db_owner] ADD MEMBER [sdnmediamanager];


GO
ALTER ROLE [db_accessadmin] ADD MEMBER [sdnmediamanager];


GO
ALTER ROLE [db_securityadmin] ADD MEMBER [sdnmediamanager];


GO
ALTER ROLE [db_ddladmin] ADD MEMBER [sdnmediamanager];


GO
ALTER ROLE [db_backupoperator] ADD MEMBER [sdnmediamanager];


GO
ALTER ROLE [db_datareader] ADD MEMBER [sdnmediamanager];


GO
ALTER ROLE [db_datawriter] ADD MEMBER [sdnmediamanager];

