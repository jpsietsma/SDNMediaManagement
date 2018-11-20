ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\Winmgmt];


GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLWriter];


GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [JIMMYBEAST-SDN\Bobswat];


GO
ALTER SERVER ROLE [serveradmin] ADD MEMBER [sdnmediamanager];


GO
ALTER SERVER ROLE [dbcreator] ADD MEMBER [sdnmediamanager];


GO
ALTER ROLE [db_owner] ADD MEMBER [sdn];

