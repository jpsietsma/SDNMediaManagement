param ( [string]$Path = "S:\", [string] $sqlUser = "sa", [string] $sqlPass = "A!12@lop^6", [string] $sqlServer = "jimmybeast-sdn", [string] $sqlInstance = "\SQLEXPRESS" )

$dropPath = "S:\~drops\tvdrop"

$downloads = Get-ChildItem $dropPath -File

$existingFiles = @()

foreach($download in $downloads){

         $downloadName = $download.Name.Replace('.sdn_tv_added', '')
         $downloadName = $downloadName.Replace('.torrent','')

    $numQuery = "SELECT TOP(20) count(pk_MediaID) FROM sortItems WHERE fileName LIKE '%" + $downloadName + "%'"
    $numResults = Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $numQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

    if($numResults["Column1"] -gt 0){

        $existingFiles += $downloadName
    }
}

foreach($file in $existingFiles){

    $updateHistoryQuery = "UPDATE sortItems SET  dlFileExists = 1, fileModified = '" + (Get-Date)  +"' WHERE fileName LIKE '%" + $file + "%'"

    Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $updateHistoryQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

}