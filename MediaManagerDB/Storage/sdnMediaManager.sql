ALTER DATABASE [$(DatabaseName)]
    ADD FILE (NAME = [sdnMediaManager], FILENAME = 'C:\Program Files\Microsoft SQL Server 2017 express\MSSQL14.SQLEXPRESS\MSSQL\DATA\sdnMediaManager.mdf', SIZE = 8192 KB, FILEGROWTH = 65536 KB) TO FILEGROUP [PRIMARY];

