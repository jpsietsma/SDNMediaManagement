Param([string] $torrentID, [string] $torrentName, [string] $torrentPath)

$sqlUser = "sa"
$sqlPass = "A!12@lop^6"
$sqlServer = "jimmybeast-sdn"
$sqlInstance = "\SQLEXPRESS"


$logLine = "Torrent Removed: [" + (Get-Date) + "] " + $torrentID + " ---- " + $torrentName + " ---- " + $torrentPath

$updateRemovedQuery = "UPDATE sdnDownloadQueue SET TorrentStatus = 'Moved/Removed' WHERE pk_torrentID = '$torrentID' "
Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $updateRemovedQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

$logLine >> C:\~sdnAutologs\deluge_log.txt

