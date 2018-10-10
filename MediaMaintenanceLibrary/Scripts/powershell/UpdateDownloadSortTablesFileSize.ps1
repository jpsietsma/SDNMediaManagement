$items = Get-Childitem -LiteralPath "S:\"

$sqlUser = "sa"
$sqlPass = "A!12@lop^6"
$sqlServer = "jimmybeast-sdn"
$sqlInstance = "\SQLEXPRESS"

foreach($item in $items){

$file = Get-Item -Path $item.FullName
if($file.Length -gt 1 -and $file.Name -ne $null){
    
    $file.FullName + " - " + $file.Length
    
    #Update sdnDownloadQueue to indicate download has finished
    $updateCompleteQuery = "UPDATE sdnDownloadQueue SET fileSize = '" + $item.Length + "' WHERE TorrentName = '" + $file.Name + "' "
    Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $updateCompleteQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

    #Update sortItems to indicate download has finished
    $update2CompleteQuery = "UPDATE sortItems SET fileSize = '" + $item.Length + "' WHERE fileName = '" + $item.Name + "' "
    Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $update2CompleteQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance


}

}

"--------------------------------------"
$items.Count