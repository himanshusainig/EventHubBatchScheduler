cd /d "D:\workspace\SampleApp\SampleApp" &msbuild "SampleApp.csproj" /t:sdvViewer /p:configuration="Debug" /p:platform=Any CPU
exit %errorlevel% 