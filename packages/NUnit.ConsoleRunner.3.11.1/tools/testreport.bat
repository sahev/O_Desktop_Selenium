del ".\xml\*.xml" 
del ".\html\*.html"

nunit3-console.exe "C:\working\Orbium_5_10_1\Orbium_5_10_1\Orbium_5_10_1\bin\Debug\Orbium_5_10_1.dll" --result="CT01CustomerEdit.xml;format=nunit3" --work=".\xml
ReportUnit.exe ".\xml" ".\html"