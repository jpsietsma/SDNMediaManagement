Param([string] $torrentID, [string] $torrentName, [string] $torrentPath)

$sqlUser = "sa"
$sqlPass = "A!12@lop^6"
$sqlServer = "jimmybeast-sdn"
$sqlInstance = "\SQLEXPRESS"


$logLine = "Download Finished: [" + (Get-Date) + "] " + $torrentID + " ---- " + $torrentName + " ---- " + $torrentPath

#Update sdnDownloadQueue to indicate download has finished
$updateCompleteQuery = "UPDATE sdnDownloadQueue SET torrentStatus = 'Download Complete', DownloadFinished = '" + (Get-Date) + "', TorrentPath = '" + $torrentPath + "' WHERE pk_torrentID = '$torrentID' "
Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $updateCompleteQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

#Insert record into sortItems table
$insertSortQuery = "INSERT INTO sortItems (filePath, fileName, hasBeenProcessed, fk_fileMediaTypeID) VALUES('" + ($torrentPath + $torrentName).Replace('\\', '\') + "', '$torrentName', '0', '3')"
Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $insertSortQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

#Write to log for diagnostic purposes
$logLine >> C:\~sdnAutologs\deluge_log.txt


