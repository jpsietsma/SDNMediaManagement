cls

$postParams = @{apikey = "0H0EDCYE0XE6GEYL"; username = "jpsietsma"; userkey = "4550538EC5427D6C"}
$postParams = $postParams | ConvertTo-Json -Compress

$token = Invoke-WebRequest -Uri https://api.thetvdb.com/login -Method POST -Body $postParams -ContentType 'application/json'
$token = $token.Content | ConvertFrom-Json
$token = $token.token
$token
