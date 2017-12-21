rem MapWinGISBin64 = c:\dev\MapWinGIS\x64\
rem %1 = $(TargetDir) = H:\Develope\Surveyer\bin\x64\Debug\

cd %MapWinGISBin64%
xcopy *.* %1\MapWinGIS\*  /Y /R /S
cd %1
VastGIS.PostBuild.exe

