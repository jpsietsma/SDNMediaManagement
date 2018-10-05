Param([string] $torrentID, [string] $torrentName, [string] $torrentPath)

$sqlUser = "sa"
$sqlPass = "A!12@lop^6"
$sqlServer = "jimmybeast-sdn"
$sqlInstance = "\SQLEXPRESS"


$logLine = "Download Added: [" + (Get-Date) + "] " + $torrentID + " ---- " + $torrentName + " ---- " + $torrentPath

$insertQuery = "INSERT INTO sdnDownloadQueue ([pk_TorrentID], [TorrentName], [TorrentPath], [DownloadStarted], [TorrentStatus]) VALUES ('" + $torrentID + "', '" + $torrentName + "', '" + $torrentPath + "', '" + (Get-Date) + "', 'Downloading')"
Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $insertQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

$logLine >> C:\~sdnAutologs\deluge_log.txt
