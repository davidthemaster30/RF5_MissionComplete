rm -rf obj
rm -rf bin

dotnet build RF5_MissionComplete.csproj -f net6.0 -c Release

zip -j 'RF5_MissionComplete_v1.2.0.zip' './bin/Release/net6.0/RF5_MissionComplete.dll'