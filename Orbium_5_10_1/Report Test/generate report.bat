del ".\xml\*.xml" 
del ".\*.html"

.\References\nunit3-console.exe "C:\working\Orbium_5_10_1\Orbium_5_10_1\Orbium_5_10_1\bin\Debug\Orbium_Desktop_5_10_1.dll" --result="Orbium_Desktop.xml;format=nunit3" --work=".\xml
.\References\ReportUnit.exe ".\xml" ".\"
