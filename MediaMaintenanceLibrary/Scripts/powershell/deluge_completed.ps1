Param([string] $torrentID, [string] $torrentName, [string] $torrentPath)

$sqlUser = "sa"
$sqlPass = "A!12@lop^6"
$sqlServer = "jimmybeast-sdn"
$sqlInstance = "\SQLEXPRESS"

$fileSize = 0
if(Test-Path -Path "$torrentPath$torrentName"){
$fieSize = (Get-Item -Path "$torrentPath$torrentName").Length
} else {

$fileSize = (Get-Item -Path "S:\$torrentName").Length

}

$logLine = "Download Finished: [" + (Get-Date) + "] " + $torrentID + " ---- " + $torrentName + " ---- " + $torrentPath + "-----" + $fileSize

#Update sdnDownloadQueue to indicate download has finished
$updateCompleteQuery = "UPDATE DownloadQueue SET torrentStatus = 'Download Complete', DownloadFinished = '" + (Get-Date) + "', TorrentPath = '" + $torrentPath + "', fileSize = '" + $fileSize + "' WHERE pk_torrentID = '$torrentID' "
Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $updateCompleteQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

#Insert record into sortItems table
$insertSortQuery = "INSERT INTO sortItems (filePath, fileName, hasBeenProcessed, fk_fileMediaTypeID, fk_torrentID, fileSize) VALUES('" + ($torrentPath + $torrentName).Replace('\\', '\') + "', '$torrentName', '0', '3', '$torrentID', '$fileSize')"
Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $insertSortQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

#Write to log for diagnostic purposes
$logLine >> C:\~sdnAutologs\deluge_log.txt


