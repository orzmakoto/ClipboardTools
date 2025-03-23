cd ../ClipboardTools
del publish\*

dotnet clean
dotnet publish -c Release -r win-x64 --self-contained true -p:PublishSingleFile=true -o publish

Compress-Archive -Path publish\* -DestinationPath publish\cbt.zip

pause