Param([string] $torrentID, [string] $torrentName, [string] $torrentPath)

$sqlUser = "sa"
$sqlPass = "A!12@lop^6"
$sqlServer = "jimmybeast-sdn"
$sqlInstance = "\SQLEXPRESS"

$fileSize = 0
if(Test-Path -Path "$torrentPath$torrentName"){
$fieSize = (Get-Item -Path "$torrentPath$torrentName").Length
$fileSize = $file.length
} else {

$fileSize = (Get-Item -Path "S:\$torrentName").Length

}

$logLine = "Download Finished: [" + (Get-Date) + "] " + $torrentID + " ---- " + $torrentName + " ---- " + $torrentPath + "-----" + $fileSize

#Update sdnDownloadQueue to indicate download has finished
$updateCompleteQuery = "UPDATE sdnDownloadQueue SET torrentStatus = 'Download Complete', DownloadFinished = '" + (Get-Date) + "', TorrentPath = '" + $torrentPath + "', FileSize = '" + $fileSize + "' WHERE pk_torrentID = '$torrentID' "
Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $updateCompleteQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

#Insert record into sortItems table
$insertSortQuery = "INSERT INTO sortItems (filePath, fileName, hasBeenProcessed, fk_fileMediaTypeID, fk_TorrentID, fileSize) VALUES('" + ($torrentPath + $torrentName).Replace('\\', '\') + "', '$torrentName', '0', '3', '$TorrentID', '$fileSize')"
Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $insertSortQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

#Write to log for diagnostic purposes
$logLine >> C:\~sdnAutologs\deluge_log.txt


