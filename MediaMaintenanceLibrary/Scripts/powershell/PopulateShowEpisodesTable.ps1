cls
$liveMediaDrives = "E:\TV Shows", "F:\TV Shows", "G:\TV Shows", "H:\TV Shows", "I:\TV Shows"
$sqlUser = "sa"
$sqlPass = "A!12@lop^6"
$sqlServer = "jimmybeast-sdn"
$sqlInstance = "\SQLEXPRESS"

#Purge existing Shows in the database
#$purgeTelevisionShowsQuery = "DELETE FROM dbo.sdnTelevisionShows WHERE ShowName <> 'Cops'"
#Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $purgeTelevisionShowsQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

$i = 0
$ep = 0
foreach($drive in $liveMediaDrives){

    foreach($folder in (Get-ChildItem -LiteralPath $drive)){

        if($folder.Name -ne "Cops"){

            $ShowName = $folder.Name
            $ShowHomePath = $folder.FullName
            $ShowDriveLetter = $folder.FullName[0]
            $IsEnabled = 1

            #foreach season count
            foreach($season in (Get-ChildItem -LiteralPath $folder.FullName)){

                #foreach episode within the season
                foreach($episode in (Get-ChildItem -LiteralPath $season.FullName -File)){

                    $ep = $ep + 1

                }

            }

            $ShowNumEpisodes = $ep
            $ShowNumSeasons = (Get-ChildItem -LiteralPath $folder.FullName).Count
            $ShowAlbumArtPath = "~/tmp/img/0.jpg"
            $ShowName = $ShowName.Replace("'", "''")
            $ShowHomePath = $ShowHomePath.Replace("'", "''")

            #Insert record into sdnTelevisionShows table
            $insertShowQuery = "INSERT INTO sdnTelevisionShows (ShowName, ShowDriveLetter, ShowHomePath, ShowNumSeasons, ShowNumEpisodes, ShowAlbumArtPath, IsEnabled) VALUES('$($ShowName)', '$ShowDriveLetter', '$($ShowHomePath)', '$ShowNumSeasons', '$ShowNumEpisodes', '$ShowAlbumArtPath', '$IsEnabled')"
            Invoke-SQLcmd -ServerInstance  $sqlServer$sqlInstance -query $insertShowQuery -U $sqlUser -P $sqlPass -Database sdnMediaManager -HostName $sqlServer$sqlInstance

            #reset count for next iteration
            $ep = 0
        }
    }
}