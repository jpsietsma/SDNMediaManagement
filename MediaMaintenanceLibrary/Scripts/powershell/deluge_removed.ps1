Param([string] $torrentID, [string] $torrentName, [string] $torrentPath)

$sqlUser = "sa"
$sqlPass = "A!12@lop^6"
$sqlServer = "jimmybeast-sdn"
$sqlInstance = "\SQLEXPRESS"


$logLine = "Torrent Removed: [" + (Get-Date) + "] " + $torrentID + " ---- " + $torrentName + " ---- " + $torrentPath

$removeQuery = "DELETE FROM DownloadQueue WHERE TorrentName = '$torrentName' "
Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $removeQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

$logLine >> deluge_log.txt

