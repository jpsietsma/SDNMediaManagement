param ( [string]$Path = "S:\", [string] $sqlUser = "sa", [string] $sqlPass = "A!12@lop^6", [string] $sqlServer = "jimmybeast-sdn", [string] $sqlInstance = "\SQLEXPRESS" )

$sqlRefreshQuery = "DELETE FROM sortItems WHERE fileNameSanitized is null"

Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $sqlRefreshQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

$files = Get-ChildItem $Path -File
$unsanitized = @()

foreach($file in $files){

    $numRecordsQuery = "SELECT count(pk_MediaID) FROM sortItems WHERE fileName = '" + $file.Name + "' AND fileNameSanitized IS NOT NULL"
    $numRecords = Invoke-Sqlcmd -ServerInstance $sqlServer$sqlInstance -Query $numRecordsQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

    if($numRecords["Column1"] -eq 1){
    
        #If item exists in the sortItems table, then do nothing, as above command removed all sanitized files from queue
        #Remaining files must be files that have not been sanitized, and may or may not have been processed

    } else {

        $unsanitized += $file
    }

}

    foreach($file in $unsanitized){

        $insertQuery = "INSERT INTO sortItems (filePath, fileName, hasBeenProcessed, fk_fileMediaTypeID) VALUES('" + $file.FullName + "', '$file', '0', '3')"

        Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $insertQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

    }