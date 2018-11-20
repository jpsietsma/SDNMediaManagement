ALTER DATABASE [$(DatabaseName)]
    ADD LOG FILE (NAME = [sdnMediaManager_log], FILENAME = 'C:\Program Files\Microsoft SQL Server 2017 express\MSSQL14.SQLEXPRESS\MSSQL\DATA\sdnMediaManager_log.ldf', SIZE = 8192 KB, MAXSIZE = 2097152 MB, FILEGROWTH = 65536 KB);

