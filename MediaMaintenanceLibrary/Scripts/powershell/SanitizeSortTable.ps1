param ( [string]$FileName = "all", [string] $sqlUser = "sa", [string] $sqlPass = "A!12@lop^6", [string] $sqlServer = "jimmybeast-sdn", [string] $sqlInstance = "\SQLEXPRESS" )

echo ""
echo $saniNameQuery
echo ""
echo ""

if($FileName = "all"){

    $resultsQuery = "SELECT TOP (50) * FROM sortItems WHERE hasBeenSanitized = 0 AND hasBeenProcessed = 0 ORDER BY fileName"
    $results = Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $resultsQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

    foreach($result in $results){

        $sanitizePattern = '(.+).(S\d\d)(E\d\d).+(.mkv|.avi|.mp4)'

        $showTitle = [regex]::Match($result.fileName,$sanitizePattern).captures.groups[1].value
        $seasonNum = [regex]::Match($result.fileName,$sanitizePattern).captures.groups[2].value
        $episodeNum = [regex]::Match($result.fileName,$sanitizePattern).captures.groups[3].value
        $fileExt = [regex]::Match($result.fileName,$sanitizePattern).captures.groups[4].value

        $saniName = ($showTitle + "." + $seasonNum + $episodeNum + $fileExt)

        $saniNameQuery = "UPDATE sortItems SET fileNameSanitized = '" + $saniName + "', hasBeenSanitized = 1, hasBeenProcessed = 1, finalizedFileName = '" + $saniName + "', fileModified = '" + (Get-Date) + "', finalizedShowName = '" + $showTitle.Replace('.', ' ') + "', finalizedShowSeason = '" + $seasonNum + "', finalizedShowEpisode = '" + $episodeNum + "' WHERE fileName = '" + $result.fileName + "'"

        Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $saniNameQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance
        
    }

}