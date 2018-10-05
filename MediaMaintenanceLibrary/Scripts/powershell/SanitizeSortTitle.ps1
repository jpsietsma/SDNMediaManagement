Param([string] $filename)

$sanitizePattern = '(.+).(S\d\d)(E\d\d).+(.mkv|.avi|.mp4)'

$showTitle = [regex]::Match($filename,$sanitizePattern).captures.groups[1].value
$seasonNum = [regex]::Match($filename,$sanitizePattern).captures.groups[2].value
$episodeNum = [regex]::Match($filename,$sanitizePattern).captures.groups[3].value
$fileExt = [regex]::Match($filename,$sanitizePattern).captures.groups[4].value

$saniName = ($showTitle + "." + $seasonNum + $episodeNum + $fileExt)

$saniName